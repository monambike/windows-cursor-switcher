// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Data;
using WindowsCursorSwitcher.Events;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher
{
    public partial class MainForm : Form
    {
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

            var tabSchemaMenuHandler = new TabSchemaMenuHandler(tcSchemas, cmsSchema);
            tcSchemas.MouseUp += tabSchemaMenuHandler.TcSchemas_MouseUp;
            tabSchemaMenuHandler.CreateTabsFromRegedit();
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

            UpdateCursors(testSchema.Name, testSchema.CursorPathsToString());
        }


        private void tslHowToUse_Click(object sender, EventArgs e) => UtilMessages.ShowHowToUseMessage();

        private void tsbAbout_Click(object sender, EventArgs e) => UtilMessages.ShowAboutMessage();

        private void tsbExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

        private void btnExit_Click(object sender, EventArgs e) => UtilMessages.ShowConfirmationExitMessage();

    }
}
