namespace bo3_eboot_builder
{
    partial class Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadELF = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDebugNPDRM = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressEBOOTS = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.noRecoil = new System.Windows.Forms.CheckBox();
            this.steadyAim = new System.Windows.Forms.CheckBox();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.vsat = new System.Windows.Forms.CheckBox();
            this.wallhack = new System.Windows.Forms.CheckBox();
            this.loadSPRX = new System.Windows.Forms.CheckBox();
            this.sprxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fpsCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deadBodiesFlag = new System.Windows.Forms.CheckBox();
            this.weaponsFlag = new System.Windows.Forms.CheckBox();
            this.redBoxes = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadELF,
            this.buildToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadELF
            // 
            this.loadELF.Name = "loadELF";
            this.loadELF.Size = new System.Drawing.Size(124, 22);
            this.loadELF.Text = "Load .ELF";
            this.loadELF.Click += new System.EventHandler(this.loadELF_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildDebug,
            this.buildDebugNPDRM});
            this.buildToolStripMenuItem.Enabled = false;
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildDebug
            // 
            this.buildDebug.Name = "buildDebug";
            this.buildDebug.Size = new System.Drawing.Size(186, 22);
            this.buildDebug.Text = "Debug (DEX)";
            this.buildDebug.Click += new System.EventHandler(this.buildDebug_Click);
            // 
            // buildDebugNPDRM
            // 
            this.buildDebugNPDRM.Name = "buildDebugNPDRM";
            this.buildDebugNPDRM.Size = new System.Drawing.Size(186, 22);
            this.buildDebugNPDRM.Text = "Debug (DEX) NPDRM";
            this.buildDebugNPDRM.Click += new System.EventHandler(this.buildDebugNPDRM_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressEBOOTS});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // compressEBOOTS
            // 
            this.compressEBOOTS.Name = "compressEBOOTS";
            this.compressEBOOTS.Size = new System.Drawing.Size(173, 22);
            this.compressEBOOTS.Text = "Compress EBOOTS";
            this.compressEBOOTS.Click += new System.EventHandler(this.compressEBOOTS_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 20);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // noRecoil
            // 
            this.noRecoil.AutoSize = true;
            this.noRecoil.Enabled = false;
            this.noRecoil.Location = new System.Drawing.Point(178, 60);
            this.noRecoil.Name = "noRecoil";
            this.noRecoil.Size = new System.Drawing.Size(73, 17);
            this.noRecoil.TabIndex = 1;
            this.noRecoil.Text = "No Recoil";
            this.noRecoil.UseVisualStyleBackColor = true;
            // 
            // steadyAim
            // 
            this.steadyAim.AutoSize = true;
            this.steadyAim.Enabled = false;
            this.steadyAim.Location = new System.Drawing.Point(178, 37);
            this.steadyAim.Name = "steadyAim";
            this.steadyAim.Size = new System.Drawing.Size(79, 17);
            this.steadyAim.TabIndex = 1;
            this.steadyAim.Text = "Steady Aim";
            this.steadyAim.UseVisualStyleBackColor = true;
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusbar.Location = new System.Drawing.Point(0, 119);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(408, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(26, 17);
            this.status.Text = "Idle";
            // 
            // vsat
            // 
            this.vsat.AutoSize = true;
            this.vsat.Enabled = false;
            this.vsat.Location = new System.Drawing.Point(118, 37);
            this.vsat.Name = "vsat";
            this.vsat.Size = new System.Drawing.Size(54, 17);
            this.vsat.TabIndex = 3;
            this.vsat.Text = "VSAT";
            this.vsat.UseVisualStyleBackColor = true;
            // 
            // wallhack
            // 
            this.wallhack.AutoSize = true;
            this.wallhack.Enabled = false;
            this.wallhack.Location = new System.Drawing.Point(6, 19);
            this.wallhack.Name = "wallhack";
            this.wallhack.Size = new System.Drawing.Size(71, 17);
            this.wallhack.TabIndex = 4;
            this.wallhack.Text = "Wallhack";
            this.wallhack.UseVisualStyleBackColor = true;
            // 
            // loadSPRX
            // 
            this.loadSPRX.AutoSize = true;
            this.loadSPRX.Enabled = false;
            this.loadSPRX.Location = new System.Drawing.Point(275, 37);
            this.loadSPRX.Name = "loadSPRX";
            this.loadSPRX.Size = new System.Drawing.Size(82, 17);
            this.loadSPRX.TabIndex = 5;
            this.loadSPRX.Text = "Load SPRX";
            this.loadSPRX.UseVisualStyleBackColor = true;
            this.loadSPRX.CheckedChanged += new System.EventHandler(this.loadSPRX_CheckedChanged);
            // 
            // sprxName
            // 
            this.sprxName.Enabled = false;
            this.sprxName.Location = new System.Drawing.Point(275, 77);
            this.sprxName.Name = "sprxName";
            this.sprxName.Size = new System.Drawing.Size(112, 20);
            this.sprxName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter name:";
            // 
            // fpsCheckbox
            // 
            this.fpsCheckbox.AutoSize = true;
            this.fpsCheckbox.Enabled = false;
            this.fpsCheckbox.Location = new System.Drawing.Point(118, 60);
            this.fpsCheckbox.Name = "fpsCheckbox";
            this.fpsCheckbox.Size = new System.Drawing.Size(46, 17);
            this.fpsCheckbox.TabIndex = 8;
            this.fpsCheckbox.Text = "FPS";
            this.fpsCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deadBodiesFlag);
            this.groupBox1.Controls.Add(this.weaponsFlag);
            this.groupBox1.Controls.Add(this.wallhack);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Render Flags";
            // 
            // deadBodiesFlag
            // 
            this.deadBodiesFlag.AutoSize = true;
            this.deadBodiesFlag.Enabled = false;
            this.deadBodiesFlag.Location = new System.Drawing.Point(6, 61);
            this.deadBodiesFlag.Name = "deadBodiesFlag";
            this.deadBodiesFlag.Size = new System.Drawing.Size(87, 17);
            this.deadBodiesFlag.TabIndex = 6;
            this.deadBodiesFlag.Text = "Dead Bodies";
            this.deadBodiesFlag.UseVisualStyleBackColor = true;
            // 
            // weaponsFlag
            // 
            this.weaponsFlag.AutoSize = true;
            this.weaponsFlag.Enabled = false;
            this.weaponsFlag.Location = new System.Drawing.Point(6, 40);
            this.weaponsFlag.Name = "weaponsFlag";
            this.weaponsFlag.Size = new System.Drawing.Size(72, 17);
            this.weaponsFlag.TabIndex = 5;
            this.weaponsFlag.Text = "Weapons";
            this.weaponsFlag.UseVisualStyleBackColor = true;
            // 
            // redBoxes
            // 
            this.redBoxes.AutoSize = true;
            this.redBoxes.Location = new System.Drawing.Point(118, 83);
            this.redBoxes.Name = "redBoxes";
            this.redBoxes.Size = new System.Drawing.Size(78, 17);
            this.redBoxes.TabIndex = 10;
            this.redBoxes.Text = "Red Boxes";
            this.redBoxes.UseVisualStyleBackColor = true;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 141);
            this.Controls.Add(this.redBoxes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fpsCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprxName);
            this.Controls.Add(this.loadSPRX);
            this.Controls.Add(this.vsat);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.steadyAim);
            this.Controls.Add(this.noRecoil);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Builder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Ops III EBOOT Builder | Tustin";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadELF;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildDebug;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.CheckBox noRecoil;
        private System.Windows.Forms.CheckBox steadyAim;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.CheckBox vsat;
        private System.Windows.Forms.CheckBox wallhack;
        private System.Windows.Forms.CheckBox loadSPRX;
        private System.Windows.Forms.TextBox sprxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressEBOOTS;
        private System.Windows.Forms.ToolStripMenuItem buildDebugNPDRM;
        private System.Windows.Forms.CheckBox fpsCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deadBodiesFlag;
        private System.Windows.Forms.CheckBox weaponsFlag;
        private System.Windows.Forms.CheckBox redBoxes;
    }
}

