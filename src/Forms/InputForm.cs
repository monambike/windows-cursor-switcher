// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Forms
{
    public partial class InputForm : Form
    {
        public string InputValue { get; private set; }

        public string LabelText
        {
            set
            {
                lblText.Text = value;
            }
        }

        public InputForm(string labelText)
        {
            InitializeComponent();
            LabelText = labelText;
        }

        private void Ok()
        {
            InputValue = txtInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e) => Ok();
    }
}
