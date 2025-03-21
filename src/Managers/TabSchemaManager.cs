// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Windows.Forms;
using WindowsCursorSwitcher.Entities;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Managers
{
    internal class TabSchemaManager(TabControl tcSchemas, ContextMenuStrip cmsSchema)
    {
        private readonly TabControl _tcSchemas = tcSchemas;

        private readonly ContextMenuStrip _cmsSchema = cmsSchema;

        internal List<TabSchemaPageManager> TabSchemaPageManagers = [];

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

        internal void CreateTabsFromRegedit()
        {
            var keyValues = UtilRegedit.ReadKeyValues();

            if (keyValues.Count > 0)
            {
                foreach (var key in keyValues)
                {
                    TabPage newTab = new(key.Key);
                    _tcSchemas.TabPages.Add(newTab);

                    string[] items = key.Value.ToString().Split(',');
                    List<string> itemList = items.Select(i => i.Trim()).ToList();

                    var tableLayoutPanel = new TableLayoutPanel
                    {
                        AutoScroll = true,
                        AutoSize = true,
                        ColumnCount = 3,
                        ColumnStyles = { new(SizeType.Percent, 30), new(SizeType.Percent, 70), new(SizeType.AutoSize) },
                        Dock = DockStyle.Fill,
                        RowCount = itemList.Count
                    };

                    var tabSchemaPageManager = new TabSchemaPageManager { TabPage = newTab };
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        var label = new Label()
                        {
                            Dock = DockStyle.Fill,
                            Text = $"{SystemCursors.Cursors[i].WindowsName} ({SystemCursors.Cursors[i].RegeditName})"
                        };
                        tableLayoutPanel.Controls.Add(label, 0, i);

                        var textBox = new TextBox()
                        {
                            Dock = DockStyle.Fill,
                            Text = itemList[i]
                        };
                        tableLayoutPanel.Controls.Add(textBox, 1, i);
                        tabSchemaPageManager.TextBoxes.Add(textBox);

                        var button = new Button()
                        {
                            AutoSize = true,
                            Image = Properties.Resources.folder,
                            ImageAlign = ContentAlignment.MiddleLeft,
                            Text = "Select Folder",
                            TextImageRelation = TextImageRelation.ImageBeforeText
                        };
                        tableLayoutPanel.Controls.Add(button, 2, i);
                        tabSchemaPageManager.Button = button;

                        button.Click += (sender, e) =>
                        {
                            var openFileDialog = new OpenFileDialog()
                            {
                                Title = "Select a Cursor File",
                                Filter = "Cursor Files (*.cur;*.ani)|*.cur;*.ani",
                                Multiselect = false
                            };
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                var relativePath = Path.GetRelativePath(Application.StartupPath, openFileDialog.FileName);
                                textBox.Text = relativePath;
                            }
                        };
                    }
                    newTab.Controls.Add(tableLayoutPanel);
                    TabSchemaPageManagers.Add(tabSchemaPageManager);
                }
            }
        }

        internal class TabSchemaPageManager
        {
            internal TabPage TabPage { get; set; }

            internal List<TextBox> TextBoxes { get; set; } = [];

            internal Button Button { get; set; }
        }
    }
}
