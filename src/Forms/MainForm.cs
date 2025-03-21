// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Windows.Forms;
using WindowsCursorSwitcher.Data;
using WindowsCursorSwitcher.Entities;
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

            foreach (var directory in directories)
            {
                (string[] curFiles, string[]aniFiles) = (Directory.GetFiles(directory, "*.cur"), Directory.GetFiles(directory, "*.ani"));
                string[] files = [.. curFiles, .. aniFiles];

                var tableLayoutPanel = new TableLayoutPanel
                {
                    AutoSize = true,
                    ColumnCount = 1,
                    ColumnStyles = { new(SizeType.AutoSize), new(SizeType.Percent, 100) },
                    Dock = DockStyle.Fill,
                    RowCount = 2
                };
                pnlImportedCursors.Controls.Add(tableLayoutPanel);

                var label = new Label()
                {
                    Dock = DockStyle.Fill,
                    Text = $"{Path.GetFileName(directory)}"
                };
                tableLayoutPanel.Controls.Add(label, 0, 0);

                var flowLayoutPanel = new FlowLayoutPanel()
                {
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 1);
                foreach (var file in files)
                {

                    var tableLayoutPanelInner = new TableLayoutPanel
                    {
                        AutoSize = true,
                        ColumnCount = 1,
                        ColumnStyles = { new(SizeType.Absolute, 64) },
                        Dock = DockStyle.Fill,
                        RowCount = 3,
                        RowStyles = { new(SizeType.Absolute, 64) }
                    };
                    flowLayoutPanel.Controls.Add(tableLayoutPanelInner);

                    Icon icon = Icon.ExtractAssociatedIcon(file);
                    Bitmap bitmap = icon.ToBitmap();
                    var image = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = bitmap
                    };
                    tableLayoutPanelInner.Controls.Add(image, 0, 0);

                    var name = new Label()
                    {
                        Dock = DockStyle.Fill,
                        Text = $"{Path.GetFileName(directory)}"
                    };
                    tableLayoutPanelInner.Controls.Add(name, 0, 1);

                    var path = new Label()
                    {
                        Dock = DockStyle.Fill,
                        Text = $"{directory}"
                    };
                    tableLayoutPanelInner.Controls.Add(path, 0, 2);
                }
            }
        }
    }
}
