namespace WindowsCursorSwitcher.Forms
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            lblText = new Label();
            txtInput = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnOk = new Button();
            btnCancel = new Button();
            tlpMain.SuspendLayout();
            tlpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(lblText, 0, 0);
            tlpMain.Controls.Add(txtInput, 0, 2);
            tlpMain.Controls.Add(tlpButtons, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(384, 161);
            tlpMain.TabIndex = 0;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(3, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(38, 15);
            lblText.TabIndex = 0;
            lblText.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Fill;
            txtInput.Location = new Point(3, 100);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(378, 23);
            txtInput.TabIndex = 2;
            // 
            // tlpButtons
            // 
            tlpButtons.AutoSize = true;
            tlpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle());
            tlpButtons.ColumnStyles.Add(new ColumnStyle());
            tlpButtons.Controls.Add(btnOk, 1, 0);
            tlpButtons.Controls.Add(btnCancel, 2, 0);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.Location = new Point(3, 129);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(378, 29);
            tlpButtons.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(219, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(tlpMain);
            Name = "InputForm";
            Text = "InputForm";
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblText;
        private TextBox txtInput;
        private TableLayoutPanel tlpButtons;
        private Button btnOk;
        private Button btnCancel;
    }
}