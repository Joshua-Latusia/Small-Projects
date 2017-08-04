namespace SimpleTicTacToe
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
            this.button_A1 = new System.Windows.Forms.Button();
            this.button_A2 = new System.Windows.Forms.Button();
            this.button_C1 = new System.Windows.Forms.Button();
            this.button_C3 = new System.Windows.Forms.Button();
            this.button_C2 = new System.Windows.Forms.Button();
            this.button_B3 = new System.Windows.Forms.Button();
            this.button_B2 = new System.Windows.Forms.Button();
            this.button_B1 = new System.Windows.Forms.Button();
            this.button_A3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turn_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_A1
            // 
            this.button_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_A1.Location = new System.Drawing.Point(10, 27);
            this.button_A1.Name = "button_A1";
            this.button_A1.Size = new System.Drawing.Size(75, 75);
            this.button_A1.TabIndex = 0;
            this.button_A1.Text = ".";
            this.button_A1.UseVisualStyleBackColor = true;
            this.button_A1.Click += new System.EventHandler(this.button_click);
            // 
            // button_A2
            // 
            this.button_A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_A2.Location = new System.Drawing.Point(91, 27);
            this.button_A2.Name = "button_A2";
            this.button_A2.Size = new System.Drawing.Size(75, 75);
            this.button_A2.TabIndex = 1;
            this.button_A2.Text = ".";
            this.button_A2.UseVisualStyleBackColor = true;
            this.button_A2.Click += new System.EventHandler(this.button_click);
            // 
            // button_C1
            // 
            this.button_C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_C1.Location = new System.Drawing.Point(10, 189);
            this.button_C1.Name = "button_C1";
            this.button_C1.Size = new System.Drawing.Size(75, 75);
            this.button_C1.TabIndex = 2;
            this.button_C1.Text = ".";
            this.button_C1.UseVisualStyleBackColor = true;
            this.button_C1.Click += new System.EventHandler(this.button_click);
            // 
            // button_C3
            // 
            this.button_C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_C3.Location = new System.Drawing.Point(172, 189);
            this.button_C3.Name = "button_C3";
            this.button_C3.Size = new System.Drawing.Size(75, 75);
            this.button_C3.TabIndex = 3;
            this.button_C3.Text = ".";
            this.button_C3.UseVisualStyleBackColor = true;
            this.button_C3.Click += new System.EventHandler(this.button_click);
            // 
            // button_C2
            // 
            this.button_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_C2.Location = new System.Drawing.Point(91, 189);
            this.button_C2.Name = "button_C2";
            this.button_C2.Size = new System.Drawing.Size(75, 75);
            this.button_C2.TabIndex = 4;
            this.button_C2.Text = ".";
            this.button_C2.UseVisualStyleBackColor = true;
            this.button_C2.Click += new System.EventHandler(this.button_click);
            // 
            // button_B3
            // 
            this.button_B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_B3.Location = new System.Drawing.Point(172, 108);
            this.button_B3.Name = "button_B3";
            this.button_B3.Size = new System.Drawing.Size(75, 75);
            this.button_B3.TabIndex = 5;
            this.button_B3.Text = ".";
            this.button_B3.UseVisualStyleBackColor = true;
            this.button_B3.Click += new System.EventHandler(this.button_click);
            // 
            // button_B2
            // 
            this.button_B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_B2.Location = new System.Drawing.Point(91, 108);
            this.button_B2.Name = "button_B2";
            this.button_B2.Size = new System.Drawing.Size(75, 75);
            this.button_B2.TabIndex = 6;
            this.button_B2.Text = ".";
            this.button_B2.UseVisualStyleBackColor = true;
            this.button_B2.Click += new System.EventHandler(this.button_click);
            // 
            // button_B1
            // 
            this.button_B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_B1.Location = new System.Drawing.Point(10, 108);
            this.button_B1.Name = "button_B1";
            this.button_B1.Size = new System.Drawing.Size(75, 75);
            this.button_B1.TabIndex = 7;
            this.button_B1.Text = ".";
            this.button_B1.UseVisualStyleBackColor = true;
            this.button_B1.Click += new System.EventHandler(this.button_click);
            // 
            // button_A3
            // 
            this.button_A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_A3.Location = new System.Drawing.Point(172, 27);
            this.button_A3.Name = "button_A3";
            this.button_A3.Size = new System.Drawing.Size(75, 75);
            this.button_A3.TabIndex = 8;
            this.button_A3.Text = ".";
            this.button_A3.UseVisualStyleBackColor = true;
            this.button_A3.Click += new System.EventHandler(this.button_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.closeGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.closeGameToolStripMenuItem.Text = "Close Game";
            this.closeGameToolStripMenuItem.Click += new System.EventHandler(this.closeGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // turn_lbl
            // 
            this.turn_lbl.AutoSize = true;
            this.turn_lbl.Location = new System.Drawing.Point(88, 284);
            this.turn_lbl.Name = "turn_lbl";
            this.turn_lbl.Size = new System.Drawing.Size(12, 13);
            this.turn_lbl.TabIndex = 11;
            this.turn_lbl.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Turn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turn_lbl);
            this.Controls.Add(this.button_A3);
            this.Controls.Add(this.button_B1);
            this.Controls.Add(this.button_B2);
            this.Controls.Add(this.button_B3);
            this.Controls.Add(this.button_C2);
            this.Controls.Add(this.button_C3);
            this.Controls.Add(this.button_C1);
            this.Controls.Add(this.button_A2);
            this.Controls.Add(this.button_A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe by Joshua Latusia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_A1;
        private System.Windows.Forms.Button button_A2;
        private System.Windows.Forms.Button button_C1;
        private System.Windows.Forms.Button button_C3;
        private System.Windows.Forms.Button button_C2;
        private System.Windows.Forms.Button button_B3;
        private System.Windows.Forms.Button button_B2;
        private System.Windows.Forms.Button button_B1;
        private System.Windows.Forms.Button button_A3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label turn_lbl;
        private System.Windows.Forms.Label label1;
    }
}

