// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Forms;
using WindowsCursorSwitcher.Helpers;
using WindowsCursorSwitcher.Managers;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher
{
    public partial class MainForm : Form
    {
        internal TabSchemaManager TabSchemaManager { get; set; }

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Validates if the application is run as administrator.
            UtilApplication.ValidateIfRunAsAdministrator();

            // Updates imported cursors panel.
            var tabImportCursors = new TabImportCursors(pnlImportedCursors, ActiveControl);
            tabImportCursors.UpdateImportedCursors();

            // Updates user windows schemas using data from RegEdit.
            TabSchemaManager = new TabSchemaManager(tcSchemas, cmsSchema, bsSchema);
            tcSchemas.MouseUp += TabSchemaManager.TcSchemas_MouseUp;
            TabSchemaManager.UpdateSchemasFromRegedit();

            // Checks how much tabs are in schema tab.
            CheckSchemaTabsCount();
        }

        private void tslHowToUse_Click(object sender, EventArgs e) => UtilMessages.ShowHowToUseMessage();

        private void tsbAbout_Click(object sender, EventArgs e) => UtilMessages.ShowAboutMessage();

        private void tsbExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

        private void btnExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

        private void btnSave_Click(object sender, EventArgs e) => Save();

        private void tcSchemas_SelectedIndexChanged(object sender, EventArgs e) => CheckSchemaTabsCount();

        private void btnImportCursorsFromFolder_Click(object sender, EventArgs e) => ImportCursorsFromFolder();

        private void btnImportCursorFiles_Click(object sender, EventArgs e) => ImportCursorFiles();

        private void lblWindowsMouseProperties_Click(object sender, EventArgs e) => FileHelper.OpenWindowsMousePropertiesWindow();


        internal void Save()
        {
            int selectedIndex = tcSchemas.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string concatenatedValues = string.Join(",", TabSchemaManager.TabSchemaPageManagers.Select(tsm => tsm.TextBoxes.Select(txt => txt.Text)));
            }
        }
        internal void CheckSchemaTabsCount()
        {
            bool hasTabs = tcSchemas.TabPages.Count > 0;

            btnSave.Enabled = hasTabs;
        }

        internal string SetImportedCursorsToGroup()
        {
            using (var inputForm = new ChooseCursorGroupForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return inputForm.Result;
                }
            }
            return string.Empty;
        }

        internal void ImportCursorsFromFolder()
        {
            FileHelper.OpenFolderDialog();

            SetImportedCursorsToGroup();
        }

        internal void ImportCursorFiles()
        {
            FileHelper.OpenFileDialog();
        }
    }
}
