// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Entities;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Events
{
    internal class TabSchemaMenuHandler(TabControl tcSchemas, ContextMenuStrip cmsSchema)
    {
        private readonly TabControl _tcSchemas = tcSchemas;

        private readonly ContextMenuStrip _cmsSchema = cmsSchema;

        internal void TcSchemas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tcSchemas.TabCount; i++)
                {
                    Rectangle rectangle = tcSchemas.GetTabRect(i);
                    if (rectangle.Contains(e.Location))
                    {
                        tcSchemas.SelectedIndex = i;
                        cmsSchema.Show(tcSchemas, e.Location);
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
                    tcSchemas.TabPages.Add(newTab);

                    string[] items = key.Value.ToString().Split(',');
                    List<string> itemList = items.Select(i => i.Trim()).ToList();

                    var tableLayoutPanel = new TableLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        ColumnCount = 2,
                        AutoSize = true,
                        RowCount = itemList.Count,
                        AutoScroll = true,
                        ColumnStyles = { new ColumnStyle(SizeType.Percent, 10), new ColumnStyle(SizeType.Percent, 90) }
                    };

                    for (int i = 0; i < itemList.Count; i++)
                    {
                        var label = new Label()
                        {
                            Text = SystemCursors.Cursors[i].RegeditName
                        };
                        tableLayoutPanel.Controls.Add(label, 0, i);

                        var textBox = new TextBox()
                        {
                            Text = itemList[i],
                            Dock = DockStyle.Fill
                        };
                        tableLayoutPanel.Controls.Add(textBox, 1, i);
                    }
                    newTab.Controls.Add(tableLayoutPanel);
                }
            }
        }
    }
}
