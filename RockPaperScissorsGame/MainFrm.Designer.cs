namespace RockPaperScissorsGame
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LYS = new System.Windows.Forms.Label();
            this.LD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LCS = new System.Windows.Forms.Label();
            this.BtnR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LCC = new System.Windows.Forms.Label();
            this.BtnS = new System.Windows.Forms.Button();
            this.BtnP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.aboutGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(258, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.NewGameToolStripMenuItem.Text = "New Game";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // aboutGameToolStripMenuItem
            // 
            this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
            this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.aboutGameToolStripMenuItem.Text = "About Game";
            this.aboutGameToolStripMenuItem.Click += new System.EventHandler(this.AboutGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LYS
            // 
            this.LYS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LYS.AutoSize = true;
            this.LYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LYS.Location = new System.Drawing.Point(44, 518);
            this.LYS.Name = "LYS";
            this.LYS.Size = new System.Drawing.Size(114, 20);
            this.LYS.TabIndex = 1;
            this.LYS.Text = "Your Score :";
            // 
            // LD
            // 
            this.LD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LD.AutoSize = true;
            this.LD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LD.Location = new System.Drawing.Point(567, 518);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(65, 20);
            this.LD.TabIndex = 2;
            this.LD.Text = "Draw :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chose Between Rock Paper And Scissors";
            // 
            // LCS
            // 
            this.LCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCS.AutoSize = true;
            this.LCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LCS.Location = new System.Drawing.Point(279, 518);
            this.LCS.Name = "LCS";
            this.LCS.Size = new System.Drawing.Size(157, 20);
            this.LCS.TabIndex = 7;
            this.LCS.Text = "Computer Score :";
            // 
            // BtnR
            // 
            this.BtnR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnR.AutoSize = true;
            this.BtnR.BackColor = System.Drawing.Color.White;
            this.BtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnR.Image = ((System.Drawing.Image)(resources.GetObject("BtnR.Image")));
            this.BtnR.Location = new System.Drawing.Point(12, 56);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(233, 233);
            this.BtnR.TabIndex = 8;
            this.BtnR.Text = "Rock";
            this.BtnR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnR.UseVisualStyleBackColor = false;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LCC);
            this.panel1.Controls.Add(this.BtnS);
            this.panel1.Controls.Add(this.BtnP);
            this.panel1.Controls.Add(this.BtnR);
            this.panel1.Controls.Add(this.LCS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LD);
            this.panel1.Controls.Add(this.LYS);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 547);
            this.panel1.TabIndex = 9;
            // 
            // LCC
            // 
            this.LCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCC.AutoSize = true;
            this.LCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LCC.Location = new System.Drawing.Point(228, 371);
            this.LCC.Name = "LCC";
            this.LCC.Size = new System.Drawing.Size(0, 25);
            this.LCC.TabIndex = 11;
            // 
            // BtnS
            // 
            this.BtnS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnS.AutoSize = true;
            this.BtnS.BackColor = System.Drawing.Color.White;
            this.BtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnS.Image = ((System.Drawing.Image)(resources.GetObject("BtnS.Image")));
            this.BtnS.Location = new System.Drawing.Point(490, 56);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(233, 233);
            this.BtnS.TabIndex = 10;
            this.BtnS.Text = "Scissors";
            this.BtnS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnS.UseVisualStyleBackColor = false;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // BtnP
            // 
            this.BtnP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnP.AutoSize = true;
            this.BtnP.BackColor = System.Drawing.Color.White;
            this.BtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnP.Image = ((System.Drawing.Image)(resources.GetObject("BtnP.Image")));
            this.BtnP.Location = new System.Drawing.Point(251, 56);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(233, 233);
            this.BtnP.TabIndex = 9;
            this.BtnP.Text = "Paper";
            this.BtnP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnP.UseVisualStyleBackColor = false;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 547);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Rock Paper Scissors Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LYS;
        private System.Windows.Forms.Label LD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LCS;
        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnS;
        private System.Windows.Forms.Button BtnP;
        private System.Windows.Forms.Label LCC;
    }
}