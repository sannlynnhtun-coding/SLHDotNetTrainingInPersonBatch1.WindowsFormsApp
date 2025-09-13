namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            productToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem1 = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, saleToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productToolStripMenuItem1 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 29);
            productToolStripMenuItem.Text = "Setup";
            // 
            // productToolStripMenuItem1
            // 
            productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            productToolStripMenuItem1.Size = new Size(176, 34);
            productToolStripMenuItem1.Text = "Product";
            productToolStripMenuItem1.Click += productToolStripMenuItem1_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(60, 29);
            saleToolStripMenuItem.Text = "Sale";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(84, 29);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem1;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}