// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Diagnostics;
using WindowsCursorSwitcher.Data;
using WindowsCursorSwitcher.Managers;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher
{
    public partial class MainForm : Form
    {
        internal TabSchemaManager TabSchemaManager { get; set; }

        public MainForm() => InitializeComponent();


        private void UpdateCursors(string name, string value)
        {


            UtilRegedit.ModifyKeyValue(name, value);

            MessageBox.Show($"Name: {name}{Environment.NewLine + Environment.NewLine}Cursor Paths: {value}");
        }
        private void CheckIfRunAsAdministrator()
        {
            if (!UtilApplication.IsRunAsAdministrator())
            {

                var dialogResult =
                    MessageBox.Show(
                        $@"The app needs to be run in administrator mode in order to change the ""Windows Variables"" and change the cursors."
                        + Environment.NewLine
                        + "Right Click the Executable > Properties > Shortcut > Advanced > Run as Administrator",
                        "Administrator Privileges Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK) Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckIfRunAsAdministrator();
            CreatePanel();
            TabSchemaManager = new TabSchemaManager(tcSchemas, cmsSchema, bsSchema);
            tcSchemas.MouseUp += TabSchemaManager.TcSchemas_MouseUp;
            TabSchemaManager.UpdateSchemasFromRegedit();
            CheckSchemaTabsCount();
        }


        private void tsbView_Click(object sender, EventArgs e)
        {
            string names = "";
            foreach (var value in UtilRegedit.ReadKeyValues()) names += value + Environment.NewLine;

            MessageBox.Show(names);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            var testSchema = TestCursors.TestSchema;
        }


        private void tslHowToUse_Click(object sender, EventArgs e) => UtilMessages.ShowHowToUseMessage();

        private void tsbAbout_Click(object sender, EventArgs e) => UtilMessages.ShowAboutMessage();

        private void tsbExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

        private void btnExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

        private void btnSave_Click(object sender, EventArgs e) => Save();

        private void tcSchemas_SelectedIndexChanged(object sender, EventArgs e) => CheckSchemaTabsCount();

        internal void Save()
        {
            int selectedIndex = tcSchemas.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string concatenatedValues = string.Join(",", TabSchemaManager.TabSchemaPageManagers.Select(tsm => tsm.TextBoxes.Select(txt => txt.Text)));
            }
        }
        private void CheckSchemaTabsCount()
        {
            bool hasTabs = tcSchemas.TabPages.Count > 0;

            //lblUserSchemasAndCursors.Text = $"User Schemas ({tcSchemas.TabPages.Count}) | Cursors ({itemList.Select(item => !string.IsNullOrWhiteSpace(item)).Count()})";

            btnSave.Enabled = hasTabs;
        }

        private void btnSelectFromFolder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var relativePath = Path.GetRelativePath(Application.StartupPath, folderBrowserDialog.SelectedPath);
            }
        }

        private void btnSelectFromFile_Click(object sender, EventArgs e)
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
            }
        }

        private void CreatePanel()
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
                string[] files = [.. curFiles, .. aniFiles];

                var tlpImportedCursorGroup = new TableLayoutPanel
                {
                    BackColor = Color.Azure,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    ColumnCount = 1,
                    ColumnStyles = { new(SizeType.AutoSize), new(SizeType.AutoSize) },
                };
                tlpImportedCursors.Controls.Add(tlpImportedCursorGroup, 0, directoryIndex);

                var lblCursorGroup = new Label
                {
                    Dock = DockStyle.Fill,
                    Text = $"{Path.GetFileName(directories[directoryIndex])}"
                };
                tlpImportedCursorGroup.Controls.Add(lblCursorGroup, 0, 0);

                var flpCursors = new FlowLayoutPanel
                {
                    BackColor = Color.Purple,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlowDirection = FlowDirection.LeftToRight
                };
                tlpImportedCursorGroup.Controls.Add(flpCursors, 0, 1);
                foreach (var file in files)
                {
                    var tlpCursor = new TableLayoutPanel
                    {
                        BackColor = Color.Green,
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        ColumnCount = 1,
                        ColumnStyles = { new(SizeType.Absolute, 64) },
                        Dock = DockStyle.Fill,
                        RowCount = 3,
                        RowStyles = { new(SizeType.Absolute, 64) },
                        Size = new Size(128, 128)
                    };
                    flpCursors.Controls.Add(tlpCursor);

                    Icon icon = Icon.ExtractAssociatedIcon(file);
                    Bitmap bitmap = icon.ToBitmap();

                    var pbCursorPreview = new PictureBox
                    {
                        BackColor = Color.Blue,
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Dock = DockStyle.Fill,
                        Image = bitmap
                    };
                    tlpCursor.Controls.Add(pbCursorPreview, 0, 0);

                    var cursorFileName = Path.GetFileName(file);

                    string fileAbsolutePath = Path.GetFullPath(file);
                    var cursorFilePath = fileAbsolutePath;

                    var cmsCursor = new ContextMenuStrip
                    {
                        Items =
                        {
                            new ToolStripMenuItem("Open File Location", null, (sender, e) => OpenFileLocation(fileAbsolutePath)),
                            new ToolStripSeparator(),
                            new ToolStripMenuItem("Copy File Location", null, (sender, e) => Clipboard.SetText(fileAbsolutePath))
                        }
                    };

                    var lblCursorFileName = new Label
                    {
                        BackColor = Color.Red,
                        ContextMenuStrip = cmsCursor,
                        Dock = DockStyle.Fill,
                        Text = cursorFileName
                    };
                    tlpCursor.Controls.Add(lblCursorFileName, 0, 1);

                    var lblCursorFilePath = new Label
                    {
                        BackColor = Color.Yellow,
                        ContextMenuStrip = cmsCursor,
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
            }
        }
        private void OpenFileLocation(string filePath)
        {
            try
            {
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file location: {ex.Message}");
            }
        }

        private void lblWindowsMouseProperties_Click(object sender, EventArgs e) => OpenWindowsMouseProperties();

        private void OpenWindowsMouseProperties() => Process.Start("control", "main.cpl,,1");

        private void openLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
