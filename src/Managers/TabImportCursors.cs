// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Forms;
using WindowsCursorSwitcher.Helpers;

namespace WindowsCursorSwitcher.Managers
{
    internal class TabImportCursors
    {
        Panel _pnlImportedCursors;

        Control? _activeControl;

        public TabImportCursors(Panel pnlImportedCursors, Control? activeControl)
        {
            (_pnlImportedCursors, _activeControl) = (pnlImportedCursors, activeControl);
        }

        internal void UpdateImportedCursors()
        {
            string folderPath = "../../../MyCursors/";

            string[] directories = [];

            try
            {
                directories = Directory.GetDirectories(folderPath);
            }
            catch (DirectoryNotFoundException)
            {

                Console.WriteLine($@"Directory ""{folderPath}"" was not found while trying to search for cursors.");
            }


            for (int directoryIndex = 0; directoryIndex < directories.Length; directoryIndex++)
            {
                (string[] curFiles, string[] aniFiles) = (Directory.GetFiles(directories[directoryIndex], "*.cur"), Directory.GetFiles(directories[directoryIndex], "*.ani"));
                string[] allCursorFiles = [.. curFiles, .. aniFiles];

                var flpCursors = CreateCursorGroup(directories, directoryIndex);

                foreach (var file in allCursorFiles) CreateCursor(file, flpCursors);
            }
        }

        public FlowLayoutPanel CreateCursorGroup(string[] directories, int directoryIndex)
        {
            var tlpImportedCursorGroups = new TableLayoutPanel
            {
                AutoScroll = true,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Top,
                ColumnCount = 1,
                RowCount = directories.Length
            };
            _pnlImportedCursors.Controls.Add(tlpImportedCursorGroups);

            var tlpImportedCursorGroup = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 1,
                RowCount = 3
            };
            tlpImportedCursorGroups.Controls.Add(tlpImportedCursorGroup, 0, directoryIndex);


            var inputForm = new InputForm("Insert the new name:");

            var cmsCursorGroup = new ContextMenuStrip
            {
                Items =
                {
                    new ToolStripMenuItem("Rename", null, (sender, e) => FileHelper.RenameFolder(Path.GetFileName(directories[directoryIndex]), "newName"))
                }
            };

            var lblCursorGroup = new Label
            {
                ContextMenuStrip = cmsCursorGroup,
                Dock = DockStyle.Fill,
                Font = new Font(Control.DefaultFont, FontStyle.Bold),
                Text = $"{Path.GetFileName(directories[directoryIndex])}"
            };
            tlpImportedCursorGroup.Controls.Add(lblCursorGroup, 0, 0);

            var pnlCursorGroupSeparator = new Panel
            {
                Height = 1,
                Dock = DockStyle.Top,
                BackColor = Color.Gray
            };
            tlpImportedCursorGroup.Controls.Add(pnlCursorGroupSeparator, 0, 1);

            var flpCursors = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.LeftToRight
            };
            tlpImportedCursorGroup.Controls.Add(flpCursors, 0, 2);

            return flpCursors;
        }

        public void CreateCursor(string file, FlowLayoutPanel flpCursors)
        {
            string fileAbsolutePath = Path.GetFullPath(file);
            var cursorFilePath = fileAbsolutePath;

            var cmsCursor = new ContextMenuStrip
            {
                Items =
                {
                    new ToolStripMenuItem("Open File Location", null, (sender, e) => FileHelper.OpenFileLocation(fileAbsolutePath)),
                    new ToolStripSeparator(),
                    new ToolStripMenuItem("Copy File Location", null, (sender, e) => Clipboard.SetText(fileAbsolutePath))
                }
            };

            var tlpCursor = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 1,
                Width = 150,
                Height = 150,
                ContextMenuStrip = cmsCursor,
                Dock = DockStyle.Fill,
                RowCount = 3,
            };
            flpCursors.Controls.Add(tlpCursor);

            Icon icon = Icon.ExtractAssociatedIcon(file);
            Bitmap bitmap = icon.ToBitmap();

            var pbCursorPreview = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.CenterImage,
                Dock = DockStyle.Fill,
                Image = bitmap
            };
            tlpCursor.Controls.Add(pbCursorPreview, 0, 0);

            var cursorFileName = Path.GetFileName(file);
            pbCursorPreview.Tag = cursorFileName;
            pbCursorPreview.Click += PbCursorPreview_Click;

            var lblCursorFileName = new Label
            {
                Dock = DockStyle.Fill,
                Text = cursorFileName
            };
            tlpCursor.Controls.Add(lblCursorFileName, 0, 1);

            var lblCursorFilePath = new Label
            {
                Dock = DockStyle.Fill,
                Text = cursorFilePath
            };
            tlpCursor.Controls.Add(lblCursorFilePath, 0, 2);

            var cursorToolTip = new ToolTip
            {
                InitialDelay = 1000,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = cursorFileName
            };
            cursorToolTip.SetToolTip(lblCursorFileName, cursorFilePath);
            cursorToolTip.SetToolTip(lblCursorFilePath, cursorFilePath);
        }

        private void PbCursorPreview_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is string cursorFileName)
            {
                if (_activeControl is TextBox textBox)
                {
                    //int selectionStart = textBox.SelectionStart;
                    textBox.Text = cursorFileName;
                    //textBox.SelectionStart = selectionStart + text.Length;
                }
            }
        }
    }
}
