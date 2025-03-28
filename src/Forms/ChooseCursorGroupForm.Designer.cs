namespace WindowsCursorSwitcher.Forms
{
    partial class ChooseCursorGroupForm
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
            btnCreateGroup = new Button();
            cmbCursorGroups = new ComboBox();
            lblSelectExistingGroup = new Label();
            lblSelectGroup = new Label();
            txtNewGroupName = new TextBox();
            lblCreateNewGroup = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOr = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tlpMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(btnCreateGroup, 0, 4);
            tlpMain.Controls.Add(cmbCursorGroups, 1, 1);
            tlpMain.Controls.Add(lblSelectExistingGroup, 0, 1);
            tlpMain.Controls.Add(lblSelectGroup, 0, 0);
            tlpMain.Controls.Add(txtNewGroupName, 1, 3);
            tlpMain.Controls.Add(lblCreateNewGroup, 0, 3);
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 6;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(384, 161);
            tlpMain.TabIndex = 0;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.AutoSize = true;
            btnCreateGroup.Dock = DockStyle.Fill;
            btnCreateGroup.Location = new Point(3, 97);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(120, 25);
            btnCreateGroup.TabIndex = 3;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = true;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // cmbCursorGroups
            // 
            cmbCursorGroups.Dock = DockStyle.Fill;
            cmbCursorGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCursorGroups.FormattingEnabled = true;
            cmbCursorGroups.Location = new Point(129, 18);
            cmbCursorGroups.Name = "cmbCursorGroups";
            cmbCursorGroups.Size = new Size(252, 23);
            cmbCursorGroups.TabIndex = 0;
            cmbCursorGroups.DropDownClosed += cmbCursorGroups_DropDownClosed;
            cmbCursorGroups.SelectedValueChanged += cmbCursorGroups_SelectedValueChanged;
            // 
            // lblSelectExistingGroup
            // 
            lblSelectExistingGroup.AutoSize = true;
            lblSelectExistingGroup.Dock = DockStyle.Fill;
            lblSelectExistingGroup.Location = new Point(3, 15);
            lblSelectExistingGroup.Name = "lblSelectExistingGroup";
            lblSelectExistingGroup.Size = new Size(120, 29);
            lblSelectExistingGroup.TabIndex = 5;
            lblSelectExistingGroup.Text = "Select Existing Group:";
            lblSelectExistingGroup.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectGroup
            // 
            lblSelectGroup.AutoSize = true;
            tlpMain.SetColumnSpan(lblSelectGroup, 2);
            lblSelectGroup.Dock = DockStyle.Fill;
            lblSelectGroup.Location = new Point(3, 0);
            lblSelectGroup.Name = "lblSelectGroup";
            lblSelectGroup.Size = new Size(378, 15);
            lblSelectGroup.TabIndex = 6;
            lblSelectGroup.Text = "Select Group";
            lblSelectGroup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewGroupName
            // 
            txtNewGroupName.Dock = DockStyle.Fill;
            txtNewGroupName.Location = new Point(129, 68);
            txtNewGroupName.Name = "txtNewGroupName";
            txtNewGroupName.Size = new Size(252, 23);
            txtNewGroupName.TabIndex = 1;
            txtNewGroupName.Leave += txtNewGroupName_Leave;
            // 
            // lblCreateNewGroup
            // 
            lblCreateNewGroup.AutoSize = true;
            lblCreateNewGroup.Dock = DockStyle.Fill;
            lblCreateNewGroup.Location = new Point(3, 65);
            lblCreateNewGroup.Name = "lblCreateNewGroup";
            lblCreateNewGroup.Size = new Size(120, 29);
            lblCreateNewGroup.TabIndex = 2;
            lblCreateNewGroup.Text = "Create New Group:";
            lblCreateNewGroup.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tlpMain.SetColumnSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblOr, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(378, 15);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Dock = DockStyle.Fill;
            lblOr.Location = new Point(180, 0);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(18, 15);
            lblOr.TabIndex = 5;
            lblOr.Text = "or";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(204, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 1);
            panel2.TabIndex = 7;
            // 
            // ChooseCursorGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(tlpMain);
            Name = "ChooseCursorGroupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose a Cursor Group";
            Load += ChooseCursorGroupForm_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Button btnCreateGroup;
        private Label lblCreateNewGroup;
        private TextBox txtNewGroupName;
        private ComboBox cmbCursorGroups;
        private Label lblSelectExistingGroup;
        private Label lblSelectGroup;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblOr;
        private Panel panel1;
        private Panel panel2;
    }
}