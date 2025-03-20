namespace WindowsCursorSwitcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tsMain = new ToolStrip();
            tsbView = new ToolStripButton();
            tsbUpdate = new ToolStripButton();
            tslHowToUse = new ToolStripButton();
            tsbAbout = new ToolStripButton();
            tsbExit = new ToolStripButton();
            tlpMain = new TableLayoutPanel();
            tlpUserSchemes = new TableLayoutPanel();
            tcSchemas = new TabControl();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            btnExit = new Button();
            cmsSchema = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            aaToolStripMenuItem = new ToolStripMenuItem();
            tlpPaths = new TableLayoutPanel();
            tsMain.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpUserSchemes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cmsSchema.SuspendLayout();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { tsbView, tsbUpdate, tslHowToUse, tsbAbout, tsbExit });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(784, 25);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // tsbView
            // 
            tsbView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(36, 22);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbUpdate
            // 
            tsbUpdate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbUpdate.ImageTransparentColor = Color.Magenta;
            tsbUpdate.Name = "tsbUpdate";
            tsbUpdate.Size = new Size(49, 22);
            tsbUpdate.Text = "Update";
            tsbUpdate.Click += tsbUpdate_Click;
            // 
            // tslHowToUse
            // 
            tslHowToUse.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslHowToUse.Image = (Image)resources.GetObject("tslHowToUse.Image");
            tslHowToUse.ImageTransparentColor = Color.Magenta;
            tslHowToUse.Name = "tslHowToUse";
            tslHowToUse.Size = new Size(74, 22);
            tslHowToUse.Text = "How To Use";
            tslHowToUse.Click += tslHowToUse_Click;
            // 
            // tsbAbout
            // 
            tsbAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAbout.ImageTransparentColor = Color.Magenta;
            tsbAbout.Name = "tsbAbout";
            tsbAbout.Size = new Size(44, 22);
            tsbAbout.Text = "About";
            tsbAbout.Click += tsbAbout_Click;
            // 
            // tsbExit
            // 
            tsbExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new Size(29, 22);
            tsbExit.Text = "Exit";
            tsbExit.Click += tsbExit_Click;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpUserSchemes, 0, 0);
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 25);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(784, 536);
            tlpMain.TabIndex = 2;
            // 
            // tlpUserSchemes
            // 
            tlpUserSchemes.ColumnCount = 1;
            tlpUserSchemes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUserSchemes.Controls.Add(tcSchemas, 0, 0);
            tlpUserSchemes.Controls.Add(label1, 0, 0);
            tlpUserSchemes.Dock = DockStyle.Fill;
            tlpUserSchemes.Location = new Point(3, 3);
            tlpUserSchemes.Name = "tlpUserSchemes";
            tlpUserSchemes.RowCount = 2;
            tlpUserSchemes.RowStyles.Add(new RowStyle());
            tlpUserSchemes.RowStyles.Add(new RowStyle());
            tlpUserSchemes.Size = new Size(778, 493);
            tlpUserSchemes.TabIndex = 5;
            // 
            // tcSchemas
            // 
            tcSchemas.Dock = DockStyle.Fill;
            tcSchemas.Location = new Point(3, 18);
            tcSchemas.Name = "tcSchemas";
            tcSchemas.SelectedIndex = 0;
            tcSchemas.Size = new Size(772, 480);
            tcSchemas.TabIndex = 0;
            tcSchemas.SelectedIndexChanged += tcSchemas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "User Schemes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnSave, 2, 0);
            tableLayoutPanel1.Controls.Add(btnExit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 502);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(778, 31);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(700, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.AutoSize = true;
            btnExit.Location = new Point(619, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cmsSchema
            // 
            cmsSchema.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, duplicateToolStripMenuItem, toolStripSeparator1, aaToolStripMenuItem });
            cmsSchema.Name = "contextMenuStrip1";
            cmsSchema.Size = new Size(125, 76);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(124, 22);
            testToolStripMenuItem.Text = "Rename";
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(124, 22);
            duplicateToolStripMenuItem.Text = "Duplicate";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // aaToolStripMenuItem
            // 
            aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            aaToolStripMenuItem.Size = new Size(124, 22);
            aaToolStripMenuItem.Text = "Delete";
            // 
            // tlpPaths
            // 
            tlpPaths.ColumnCount = 2;
            tlpPaths.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPaths.Dock = DockStyle.Fill;
            tlpPaths.Location = new Point(0, 0);
            tlpPaths.Name = "tlpPaths";
            tlpPaths.RowCount = 2;
            tlpPaths.Size = new Size(200, 100);
            tlpPaths.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(784, 561);
            Controls.Add(tlpMain);
            Controls.Add(tsMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Cursor Switcher";
            Load += MainForm_Load;
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpUserSchemes.ResumeLayout(false);
            tlpUserSchemes.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            cmsSchema.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton tsbAbout;
        private ToolStripButton tsbTest;
        private ToolStripButton tsbView;
        private ToolStripButton tsbUpdate;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpUserSchemes;
        private TabControl tcSchemas;
        private Label label1;
        private TableLayoutPanel tlpPaths;
        private ContextMenuStrip cmsSchema;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem aaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripButton tslHowToUse;
        private ToolStripButton tsbExit;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Button btnExit;
    }
}
