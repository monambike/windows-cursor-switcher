// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Data;
using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"""Windows Cursor Switcher"" created by: @monambike. (2025) :D Enjoy it!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

            var keyValues = UtilRegedit.ReadKeyValues();

            if (keyValues.Count > 0)
            {
                foreach (var key in keyValues)
                {
                    tcSchemas.TabPages.Add(key.Key);
                }
            }

            tcSchemas.MouseUp += TcSchemas_MouseUp;
        }

        private void TcSchemas_MouseUp(object sender, MouseEventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tslHowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Right Clicks The Tabs To:"
                + Environment.NewLine + "Rename, Duplicate or Delete Schemas.",
                "How To Use",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {

            var dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) Application.Exit();
        }
    }
}
