namespace TestApp
{
    partial class FormTestApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestApp));
            this.scintilla = new ScintillaNET.Scintilla();
            this.odAnyFile = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpellCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.Location = new System.Drawing.Point(12, 45);
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(776, 393);
            this.scintilla.TabIndex = 0;
            this.scintilla.Text = "scintilla1";
            // 
            // odAnyFile
            // 
            this.odAnyFile.FileName = "openFileDialog1";
            this.odAnyFile.Filter = "All files|*.*";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSpellCheck});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(215, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // mnuSpellCheck
            // 
            this.mnuSpellCheck.Name = "mnuSpellCheck";
            this.mnuSpellCheck.Size = new System.Drawing.Size(215, 22);
            this.mnuSpellCheck.Text = "Spell check with dictionary";
            this.mnuSpellCheck.Click += new System.EventHandler(this.MnuSpellCheck_Click);
            // 
            // FormTestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormTestApp";
            this.Text = "A test application for the VPKSoft.ScintillaSpellCheck library.";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.OpenFileDialog odAnyFile;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSpellCheck;
    }
}

