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
            GenerateCursors();
        }

        private void GenerateCursors()
        {
            var testSchema = TestCursors.TestSchema;

            //UtilRegedit.ModifyKeyValue(testSchema.Name, testSchema.CursorPathsToString());

            MessageBox.Show($"Name: {testSchema.Name}{Environment.NewLine + Environment.NewLine}Cursor Paths: {testSchema.CursorPathsToString()}");
        }
    }
}
