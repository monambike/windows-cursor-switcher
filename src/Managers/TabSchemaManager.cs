// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.ComponentModel;
using WindowsCursorSwitcher.Entities;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Managers
{
    internal class TabSchemaManager
    {
        private readonly TabControl _tcSchemas;

        private readonly ContextMenuStrip _cmsSchema;

        internal BindingSource _bsSchema;

        internal List<TabSchemaPage> TabSchemaPageManagers = [];

        internal List<Schema> Schemas = [];

        public TabSchemaManager(TabControl tcSchemas, ContextMenuStrip cmsSchema, BindingSource bsSchema)
        {
            (_tcSchemas, _cmsSchema, _bsSchema) = (tcSchemas, cmsSchema, bsSchema);

            BindingList<Schema> cursorSchemes = [];
            _bsSchema.DataSource = cursorSchemes;
        }

        internal void TcSchemas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < _tcSchemas.TabCount; i++)
                {
                    Rectangle rectangle = _tcSchemas.GetTabRect(i);
                    if (rectangle.Contains(e.Location))
                    {
                        _tcSchemas.SelectedIndex = i;
                        _cmsSchema.Show(_tcSchemas, e.Location);
                        break;
                    }
                }
            }
        }

        internal void UpdateSchemasFromRegedit()
        {
            var regeditSchema = UtilRegedit.ReadKeyValues();

            Schemas.Clear();
            foreach(var regeditSchemaEntry in regeditSchema)
            {
                var schema = new Schema(regeditSchemaEntry.Key);
                string[] regeditPaths = regeditSchemaEntry.Value.ToString().Split(',');
                for (int regeditPathIndex = 0; regeditPathIndex < regeditPaths.Count(); regeditPathIndex++)
                {
                    schema.Cursors[regeditPathIndex].RelativePath = regeditPaths[regeditPathIndex];
                }
                Schemas.Add(schema);
            }

            if (Schemas.Count > 0)
            {
                for (int regeditSchemaIndex = 0; regeditSchemaIndex < regeditSchema.Count; regeditSchemaIndex++)
                {
                    TabPage newTab = new(regeditSchema[regeditSchemaIndex].Key);
                    _tcSchemas.TabPages.Add(newTab);

                    string[] regeditPaths = regeditSchema[regeditSchemaIndex].Value.ToString().Split(',');

                    var tableLayoutPanel = new TableLayoutPanel
                    {
                        AutoScroll = true,
                        AutoSize = true,
                        ColumnCount = 3,
                        ColumnStyles = { new(SizeType.Percent, 30), new(SizeType.Percent, 70), new(SizeType.AutoSize) },
                        Dock = DockStyle.Fill,
                        RowCount = regeditPaths.Count() + 1
                    };

                    var tabSchemaPageManager = new TabSchemaPage { TabPage = newTab };
                    for (int regeditPathIndex = 0; regeditPathIndex < regeditPaths.Count(); regeditPathIndex++)
                    {
                        var label = new Label()
                        {
                            Dock = DockStyle.Fill,
                            Text = $"{MappingCursors.Cursors[regeditPathIndex].WindowsName} ({MappingCursors.Cursors[regeditPathIndex].RegeditName})"
                        };
                        tableLayoutPanel.Controls.Add(label, 0, regeditPathIndex);

                        var textBox = new TextBox()
                        {
                            Dock = DockStyle.Fill,
                            DataBindings = { new Binding("Text", Schemas[regeditSchemaIndex].Cursors[regeditPathIndex], "RelativePath") },
                            Text = regeditPaths[regeditPathIndex]
                        };
                        tableLayoutPanel.Controls.Add(textBox, 1, regeditPathIndex);
                        tabSchemaPageManager.TextBoxes.Add(textBox);

                        var button = new Button()
                        {
                            AutoSize = true,
                            Image = Properties.Resources.arrow,
                            ImageAlign = ContentAlignment.MiddleLeft,
                            Text = "Set as Cursor",
                            TextImageRelation = TextImageRelation.ImageBeforeText
                        };
                        tableLayoutPanel.Controls.Add(button, 2, regeditPathIndex);
                        tabSchemaPageManager.Button = button;

                        button.Click += (sender, e) =>
                        {
                            MessageBox.Show("Cursor Changed!", "Hooray!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                    }
                    newTab.Controls.Add(tableLayoutPanel);
                    TabSchemaPageManagers.Add(tabSchemaPageManager);
                }
            }
        }
    }
}
