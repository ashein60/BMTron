namespace BM_Tron
{
    partial class MainForm
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
            this.easy = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.insane = new System.Windows.Forms.Button();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Black;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.ForeColor = System.Drawing.Color.White;
            this.easy.Location = new System.Drawing.Point(50, 50);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(400, 100);
            this.easy.TabIndex = 0;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Easy);
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.Color.White;
            this.startPanel.Controls.Add(this.insane);
            this.startPanel.Controls.Add(this.hard);
            this.startPanel.Controls.Add(this.medium);
            this.startPanel.Controls.Add(this.easy);
            this.startPanel.Location = new System.Drawing.Point(150, 120);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(500, 560);
            this.startPanel.TabIndex = 1;
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.Black;
            this.medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.ForeColor = System.Drawing.Color.White;
            this.medium.Location = new System.Drawing.Point(50, 170);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(400, 100);
            this.medium.TabIndex = 1;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Medium);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Black;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.ForeColor = System.Drawing.Color.White;
            this.hard.Location = new System.Drawing.Point(50, 290);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(400, 100);
            this.hard.TabIndex = 2;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Hard);
            // 
            // insane
            // 
            this.insane.BackColor = System.Drawing.Color.Black;
            this.insane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insane.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insane.ForeColor = System.Drawing.Color.White;
            this.insane.Location = new System.Drawing.Point(50, 410);
            this.insane.Name = "insane";
            this.insane.Size = new System.Drawing.Size(400, 100);
            this.insane.TabIndex = 3;
            this.insane.Text = "Insane";
            this.insane.UseVisualStyleBackColor = false;
            this.insane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Insane);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.startPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BM Tron";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.startPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button insane;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button medium;
    }
}

