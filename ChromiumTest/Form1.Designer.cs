namespace ChromiumTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gButton = new System.Windows.Forms.Button();
            this.rButton = new System.Windows.Forms.Button();
            this.hButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.newTabB = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rTabB = new System.Windows.Forms.Button();
            this.speedNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(0, 43);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(22, 23);
            this.bButton.TabIndex = 1;
            this.bButton.Text = "<";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(28, 43);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(22, 23);
            this.fButton.TabIndex = 2;
            this.fButton.Text = ">";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(168, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1179, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // gButton
            // 
            this.gButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gButton.Location = new System.Drawing.Point(1353, 43);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(30, 23);
            this.gButton.TabIndex = 4;
            this.gButton.Text = "Go";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rButton
            // 
            this.rButton.Location = new System.Drawing.Point(56, 43);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(55, 23);
            this.rButton.TabIndex = 5;
            this.rButton.Text = "Refresh";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // hButton
            // 
            this.hButton.Location = new System.Drawing.Point(117, 43);
            this.hButton.Name = "hButton";
            this.hButton.Size = new System.Drawing.Size(45, 23);
            this.hButton.TabIndex = 6;
            this.hButton.Text = "Home";
            this.hButton.UseVisualStyleBackColor = true;
            this.hButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedNetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1429, 40);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // newTabB
            // 
            this.newTabB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newTabB.Location = new System.Drawing.Point(1389, 43);
            this.newTabB.Name = "newTabB";
            this.newTabB.Size = new System.Drawing.Size(17, 23);
            this.newTabB.TabIndex = 8;
            this.newTabB.Text = "+";
            this.newTabB.UseVisualStyleBackColor = true;
            this.newTabB.Click += new System.EventHandler(this.newTabB_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1429, 600);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1421, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rTabB
            // 
            this.rTabB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rTabB.Location = new System.Drawing.Point(1412, 43);
            this.rTabB.Name = "rTabB";
            this.rTabB.Size = new System.Drawing.Size(17, 23);
            this.rTabB.TabIndex = 10;
            this.rTabB.Text = "-";
            this.rTabB.UseVisualStyleBackColor = true;
            this.rTabB.Click += new System.EventHandler(this.rTabB_Click);
            // 
            // speedNetToolStripMenuItem
            // 
            this.speedNetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.speedNetToolStripMenuItem.Image = global::ChromiumTest.Properties.Resources.logo;
            this.speedNetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.speedNetToolStripMenuItem.Name = "speedNetToolStripMenuItem";
            this.speedNetToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 670);
            this.Controls.Add(this.rTabB);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.newTabB);
            this.Controls.Add(this.hButton);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedNet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Button hButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speedNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button newTabB;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button rTabB;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

