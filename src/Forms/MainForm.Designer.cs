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
            tsddbFile = new ToolStripDropDownButton();
            tsmiFileImportFromFolder = new ToolStripMenuItem();
            tsmiFileImportFromFile = new ToolStripMenuItem();
            tssFile1 = new ToolStripSeparator();
            tsimFileSave = new ToolStripMenuItem();
            tssFile2 = new ToolStripSeparator();
            tsmiFileExit = new ToolStripMenuItem();
            tsddbSchemas = new ToolStripDropDownButton();
            tsmiSchemasRename = new ToolStripMenuItem();
            tsmiSchemasDuplicate = new ToolStripMenuItem();
            tssSchemas = new ToolStripSeparator();
            tsmiSchemasDelete = new ToolStripMenuItem();
            lblGoToWindowsMouseProperties = new ToolStripButton();
            tsbHowToUse = new ToolStripButton();
            tsbAbout = new ToolStripButton();
            tsbExit = new ToolStripButton();
            tlpMain = new TableLayoutPanel();
            tlpFooter = new TableLayoutPanel();
            btnSave = new Button();
            btnExit = new Button();
            tlpSchemas = new TableLayoutPanel();
            tlpUserSchemas = new TableLayoutPanel();
            tcSchemas = new TabControl();
            lblWindowsUserSchemas = new Label();
            tlpCursors = new TableLayoutPanel();
            lblImportCursors = new Label();
            lblImportedCursors = new Label();
            tlpImportCursors = new TableLayoutPanel();
            btnSelectFromFolder = new Button();
            btnSelectFromFile = new Button();
            tlpImportedCursors = new TableLayoutPanel();
            cmsSchema = new ContextMenuStrip(components);
            tsmiRename = new ToolStripMenuItem();
            tsmiDuplicate = new ToolStripMenuItem();
            tssSchema = new ToolStripSeparator();
            tsmiDelete = new ToolStripMenuItem();
            tlpPaths = new TableLayoutPanel();
            bsSchema = new BindingSource(components);
            tsMain.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpFooter.SuspendLayout();
            tlpSchemas.SuspendLayout();
            tlpUserSchemas.SuspendLayout();
            tlpCursors.SuspendLayout();
            tlpImportCursors.SuspendLayout();
            cmsSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsSchema).BeginInit();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { tsddbFile, tsddbSchemas, lblGoToWindowsMouseProperties, tsbHowToUse, tsbAbout, tsbExit });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(784, 25);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // tsddbFile
            // 
            tsddbFile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiFileImportFromFolder, tsmiFileImportFromFile, tssFile1, tsimFileSave, tssFile2, tsmiFileExit });
            tsddbFile.Image = (Image)resources.GetObject("tsddbFile.Image");
            tsddbFile.ImageTransparentColor = Color.Magenta;
            tsddbFile.Name = "tsddbFile";
            tsddbFile.Size = new Size(38, 22);
            tsddbFile.Text = "&File";
            // 
            // tsmiFileImportFromFolder
            // 
            tsmiFileImportFromFolder.Name = "tsmiFileImportFromFolder";
            tsmiFileImportFromFolder.Size = new Size(177, 22);
            tsmiFileImportFromFolder.Text = "Import From F&older";
            // 
            // tsmiFileImportFromFile
            // 
            tsmiFileImportFromFile.Name = "tsmiFileImportFromFile";
            tsmiFileImportFromFile.Size = new Size(177, 22);
            tsmiFileImportFromFile.Text = "Import From F&iles";
            // 
            // tssFile1
            // 
            tssFile1.Name = "tssFile1";
            tssFile1.Size = new Size(174, 6);
            // 
            // tsimFileSave
            // 
            tsimFileSave.Name = "tsimFileSave";
            tsimFileSave.Size = new Size(177, 22);
            tsimFileSave.Text = "&Save";
            // 
            // tssFile2
            // 
            tssFile2.Name = "tssFile2";
            tssFile2.Size = new Size(174, 6);
            // 
            // tsmiFileExit
            // 
            tsmiFileExit.Name = "tsmiFileExit";
            tsmiFileExit.Size = new Size(177, 22);
            tsmiFileExit.Text = "&Exit";
            // 
            // tsddbSchemas
            // 
            tsddbSchemas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbSchemas.DropDownItems.AddRange(new ToolStripItem[] { tsmiSchemasRename, tsmiSchemasDuplicate, tssSchemas, tsmiSchemasDelete });
            tsddbSchemas.Image = (Image)resources.GetObject("tsddbSchemas.Image");
            tsddbSchemas.ImageTransparentColor = Color.Magenta;
            tsddbSchemas.Name = "tsddbSchemas";
            tsddbSchemas.Size = new Size(67, 22);
            tsddbSchemas.Text = "&Schemas";
            // 
            // tsmiSchemasRename
            // 
            tsmiSchemasRename.Name = "tsmiSchemasRename";
            tsmiSchemasRename.Size = new Size(124, 22);
            tsmiSchemasRename.Text = "&Rename";
            // 
            // tsmiSchemasDuplicate
            // 
            tsmiSchemasDuplicate.Name = "tsmiSchemasDuplicate";
            tsmiSchemasDuplicate.Size = new Size(124, 22);
            tsmiSchemasDuplicate.Text = "&Duplicate";
            // 
            // tssSchemas
            // 
            tssSchemas.Name = "tssSchemas";
            tssSchemas.Size = new Size(121, 6);
            // 
            // tsmiSchemasDelete
            // 
            tsmiSchemasDelete.Name = "tsmiSchemasDelete";
            tsmiSchemasDelete.Size = new Size(124, 22);
            tsmiSchemasDelete.Text = "De&lete";
            // 
            // lblGoToWindowsMouseProperties
            // 
            lblGoToWindowsMouseProperties.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblGoToWindowsMouseProperties.Image = (Image)resources.GetObject("lblGoToWindowsMouseProperties.Image");
            lblGoToWindowsMouseProperties.ImageTransparentColor = Color.Magenta;
            lblGoToWindowsMouseProperties.Name = "lblGoToWindowsMouseProperties";
            lblGoToWindowsMouseProperties.Size = new Size(199, 22);
            lblGoToWindowsMouseProperties.Text = "&Go To \"Windows Mouse Properties\"";
            lblGoToWindowsMouseProperties.Click += lblWindowsMouseProperties_Click;
            // 
            // tsbHowToUse
            // 
            tsbHowToUse.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbHowToUse.Image = (Image)resources.GetObject("tsbHowToUse.Image");
            tsbHowToUse.ImageTransparentColor = Color.Magenta;
            tsbHowToUse.Name = "tsbHowToUse";
            tsbHowToUse.Size = new Size(74, 22);
            tsbHowToUse.Text = "&How To Use";
            tsbHowToUse.Click += tslHowToUse_Click;
            // 
            // tsbAbout
            // 
            tsbAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAbout.ImageTransparentColor = Color.Magenta;
            tsbAbout.Name = "tsbAbout";
            tsbAbout.Size = new Size(44, 22);
            tsbAbout.Text = "&About";
            tsbAbout.Click += tsbAbout_Click;
            // 
            // tsbExit
            // 
            tsbExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new Size(29, 22);
            tsbExit.Text = "&Exit";
            tsbExit.Click += tsbExit_Click;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpFooter, 0, 1);
            tlpMain.Controls.Add(tlpSchemas, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 25);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(784, 536);
            tlpMain.TabIndex = 2;
            // 
            // tlpFooter
            // 
            tlpFooter.AutoSize = true;
            tlpFooter.ColumnCount = 3;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle());
            tlpFooter.ColumnStyles.Add(new ColumnStyle());
            tlpFooter.Controls.Add(btnSave, 2, 0);
            tlpFooter.Controls.Add(btnExit, 1, 0);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(3, 502);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle());
            tlpFooter.Size = new Size(778, 31);
            tlpFooter.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(700, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 4;
            btnSave.Text = "&Save";
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
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tlpSchemas
            // 
            tlpSchemas.ColumnCount = 2;
            tlpSchemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSchemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSchemas.Controls.Add(tlpUserSchemas, 1, 0);
            tlpSchemas.Controls.Add(tlpCursors, 0, 0);
            tlpSchemas.Dock = DockStyle.Fill;
            tlpSchemas.Location = new Point(3, 3);
            tlpSchemas.Name = "tlpSchemas";
            tlpSchemas.RowCount = 1;
            tlpSchemas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSchemas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSchemas.Size = new Size(778, 493);
            tlpSchemas.TabIndex = 7;
            // 
            // tlpUserSchemas
            // 
            tlpUserSchemas.ColumnCount = 1;
            tlpUserSchemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUserSchemas.Controls.Add(tcSchemas, 0, 0);
            tlpUserSchemas.Controls.Add(lblWindowsUserSchemas, 0, 0);
            tlpUserSchemas.Dock = DockStyle.Fill;
            tlpUserSchemas.Location = new Point(392, 3);
            tlpUserSchemas.Name = "tlpUserSchemas";
            tlpUserSchemas.RowCount = 2;
            tlpUserSchemas.RowStyles.Add(new RowStyle());
            tlpUserSchemas.RowStyles.Add(new RowStyle());
            tlpUserSchemas.Size = new Size(383, 487);
            tlpUserSchemas.TabIndex = 6;
            // 
            // tcSchemas
            // 
            tcSchemas.Dock = DockStyle.Fill;
            tcSchemas.Location = new Point(3, 18);
            tcSchemas.Name = "tcSchemas";
            tcSchemas.SelectedIndex = 0;
            tcSchemas.Size = new Size(377, 480);
            tcSchemas.TabIndex = 0;
            // 
            // lblWindowsUserSchemas
            // 
            lblWindowsUserSchemas.AutoSize = true;
            lblWindowsUserSchemas.Location = new Point(3, 0);
            lblWindowsUserSchemas.Name = "lblWindowsUserSchemas";
            lblWindowsUserSchemas.Size = new Size(132, 15);
            lblWindowsUserSchemas.TabIndex = 5;
            lblWindowsUserSchemas.Text = "Windows User Schemas";
            // 
            // tlpCursors
            // 
            tlpCursors.ColumnCount = 1;
            tlpCursors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCursors.Controls.Add(lblImportCursors, 0, 0);
            tlpCursors.Controls.Add(lblImportedCursors, 0, 2);
            tlpCursors.Controls.Add(tlpImportCursors, 0, 1);
            tlpCursors.Controls.Add(tlpImportedCursors, 0, 3);
            tlpCursors.Dock = DockStyle.Fill;
            tlpCursors.Location = new Point(3, 3);
            tlpCursors.Name = "tlpCursors";
            tlpCursors.RowCount = 4;
            tlpCursors.RowStyles.Add(new RowStyle());
            tlpCursors.RowStyles.Add(new RowStyle());
            tlpCursors.RowStyles.Add(new RowStyle());
            tlpCursors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCursors.Size = new Size(383, 487);
            tlpCursors.TabIndex = 7;
            // 
            // lblImportCursors
            // 
            lblImportCursors.AutoSize = true;
            lblImportCursors.Location = new Point(3, 0);
            lblImportCursors.Name = "lblImportCursors";
            lblImportCursors.Size = new Size(86, 15);
            lblImportCursors.TabIndex = 0;
            lblImportCursors.Text = "Import Cursors";
            // 
            // lblImportedCursors
            // 
            lblImportedCursors.AutoSize = true;
            lblImportedCursors.Location = new Point(3, 52);
            lblImportedCursors.Name = "lblImportedCursors";
            lblImportedCursors.Size = new Size(99, 15);
            lblImportedCursors.TabIndex = 1;
            lblImportedCursors.Text = "Imported Cursors";
            // 
            // tlpImportCursors
            // 
            tlpImportCursors.AutoSize = true;
            tlpImportCursors.ColumnCount = 3;
            tlpImportCursors.ColumnStyles.Add(new ColumnStyle());
            tlpImportCursors.ColumnStyles.Add(new ColumnStyle());
            tlpImportCursors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpImportCursors.Controls.Add(btnSelectFromFolder, 1, 0);
            tlpImportCursors.Controls.Add(btnSelectFromFile, 0, 0);
            tlpImportCursors.Dock = DockStyle.Fill;
            tlpImportCursors.Location = new Point(3, 18);
            tlpImportCursors.Name = "tlpImportCursors";
            tlpImportCursors.RowCount = 1;
            tlpImportCursors.RowStyles.Add(new RowStyle());
            tlpImportCursors.Size = new Size(377, 31);
            tlpImportCursors.TabIndex = 3;
            // 
            // btnSelectFromFolder
            // 
            btnSelectFromFolder.AutoSize = true;
            btnSelectFromFolder.Image = Properties.Resources.folder;
            btnSelectFromFolder.Location = new Point(173, 3);
            btnSelectFromFolder.Name = "btnSelectFromFolder";
            btnSelectFromFolder.Size = new Size(174, 25);
            btnSelectFromFolder.TabIndex = 0;
            btnSelectFromFolder.Text = "Select Cursors From F&older";
            btnSelectFromFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnSelectFromFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelectFromFolder.UseVisualStyleBackColor = true;
            btnSelectFromFolder.Click += btnSelectFromFolder_Click;
            // 
            // btnSelectFromFile
            // 
            btnSelectFromFile.AutoSize = true;
            btnSelectFromFile.Image = Properties.Resources.filled;
            btnSelectFromFile.Location = new Point(3, 3);
            btnSelectFromFile.Name = "btnSelectFromFile";
            btnSelectFromFile.Size = new Size(164, 25);
            btnSelectFromFile.TabIndex = 1;
            btnSelectFromFile.Text = "Select Cursors From F&iles";
            btnSelectFromFile.TextAlign = ContentAlignment.MiddleLeft;
            btnSelectFromFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelectFromFile.UseVisualStyleBackColor = true;
            btnSelectFromFile.Click += btnSelectFromFile_Click;
            // 
            // tlpImportedCursors
            // 
            tlpImportedCursors.AutoScroll = true;
            tlpImportedCursors.AutoSize = true;
            tlpImportedCursors.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpImportedCursors.ColumnCount = 1;
            tlpImportedCursors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpImportedCursors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpImportedCursors.Dock = DockStyle.Top;
            tlpImportedCursors.Location = new Point(3, 70);
            tlpImportedCursors.Name = "tlpImportedCursors";
            tlpImportedCursors.RowCount = 1;
            tlpImportedCursors.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpImportedCursors.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpImportedCursors.Size = new Size(377, 0);
            tlpImportedCursors.TabIndex = 4;
            // 
            // cmsSchema
            // 
            cmsSchema.Items.AddRange(new ToolStripItem[] { tsmiRename, tsmiDuplicate, tssSchema, tsmiDelete });
            cmsSchema.Name = "contextMenuStrip1";
            cmsSchema.Size = new Size(125, 76);
            // 
            // tsmiRename
            // 
            tsmiRename.Name = "tsmiRename";
            tsmiRename.Size = new Size(124, 22);
            tsmiRename.Text = "Rename";
            // 
            // tsmiDuplicate
            // 
            tsmiDuplicate.Name = "tsmiDuplicate";
            tsmiDuplicate.Size = new Size(124, 22);
            tsmiDuplicate.Text = "Duplicate";
            // 
            // tssSchema
            // 
            tssSchema.Name = "tssSchema";
            tssSchema.Size = new Size(121, 6);
            // 
            // tsmiDelete
            // 
            tsmiDelete.Name = "tsmiDelete";
            tsmiDelete.Size = new Size(124, 22);
            tsmiDelete.Text = "Delete";
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
            tlpFooter.ResumeLayout(false);
            tlpFooter.PerformLayout();
            tlpSchemas.ResumeLayout(false);
            tlpUserSchemas.ResumeLayout(false);
            tlpUserSchemas.PerformLayout();
            tlpCursors.ResumeLayout(false);
            tlpCursors.PerformLayout();
            tlpImportCursors.ResumeLayout(false);
            tlpImportCursors.PerformLayout();
            cmsSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsSchema).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton tsbAbout;
        private ToolStripButton tsbTest;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpUserSchemas;
        private TabControl tcSchemas;
        private Label lblWindowsUserSchemas;
        private TableLayoutPanel tlpPaths;
        private ContextMenuStrip cmsSchema;
        private ToolStripMenuItem tsmiRename;
        private ToolStripMenuItem tsmiDelete;
        private ToolStripSeparator tssSchema;
        private ToolStripMenuItem tsmiDuplicate;
        private ToolStripButton tsbHowToUse;
        private ToolStripButton tsbExit;
        private TableLayoutPanel tlpFooter;
        private Button btnSave;
        private Button btnExit;
        private TableLayoutPanel tlpSchemas;
        private TableLayoutPanel tlpCursors;
        private Label lblImportCursors;
        private Label lblImportedCursors;
        private TableLayoutPanel tlpImportCursors;
        private Button btnSelectFromFolder;
        private Button btnSelectFromFile;
        private ToolStripDropDownButton tsddbFile;
        private ToolStripMenuItem tsmiFileImportFromFolder;
        private ToolStripMenuItem tsmiFileImportFromFile;
        private ToolStripSeparator tssFile1;
        private ToolStripMenuItem tsmiFileExit;
        private ToolStripMenuItem tsimFileSave;
        private ToolStripSeparator tssFile2;
        private ToolStripDropDownButton tsddbSchemas;
        private ToolStripMenuItem tsmiSchemasRename;
        private ToolStripMenuItem tsmiSchemasDuplicate;
        private ToolStripSeparator tssSchemas;
        private ToolStripMenuItem tsmiSchemasDelete;
        private BindingSource bsSchema;
        private ToolStripButton lblGoToWindowsMouseProperties;
        private TableLayoutPanel tlpImportedCursors;
    }
}
