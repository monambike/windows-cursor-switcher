// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Managers;

namespace WindowsCursorSwitcher.Forms
{
    public partial class ChooseCursorGroupForm : Form
    {
        public string Result { get; private set; }

        public ChooseCursorGroupForm() => InitializeComponent();

        private void cmbCursorGroups_SelectedValueChanged(object sender, EventArgs e) { }

        private void btnCreateGroup_Click(object sender, EventArgs e) => CreateNewGroup();

        internal void SelectExistingGroup()
        {
            var dialogResult = MessageBox.Show($@"Do you really want to add the cursors to the group ""{cmbCursorGroups.SelectedItem}""?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Result = cmbCursorGroups.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                cmbCursorGroups.SelectedIndex = -1;
            }
        }

        internal void CreateNewGroup()
        {
            if (string.IsNullOrWhiteSpace(txtNewGroupName.Text)) return;

            var dialogResult = MessageBox.Show($@"Do you really want to add the cursors to a new group named ""{txtNewGroupName.Text}""?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Result = txtNewGroupName.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ChooseCursorGroupForm_Load(object sender, EventArgs e)
        {
            cmbCursorGroups.DataSource = TabImportCursors.RetrieveImportedCursors();
            cmbCursorGroups.SelectedIndex = -1;
        }

        private void cmbCursorGroups_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbCursorGroups.SelectedIndex != -1)
            {
                SelectExistingGroup();
            }
        }

        private void txtNewGroupName_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null) textBox.Text = textBox.Text.Trim();
        }
    }
}
