namespace nPuzzle
{
    partial class Solution
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
            this.clcikcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clcikcount
            // 
            this.clcikcount.AutoSize = true;
            this.clcikcount.BackColor = System.Drawing.Color.Transparent;
            this.clcikcount.Font = new System.Drawing.Font("둥근모꼴", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clcikcount.ForeColor = System.Drawing.Color.Gold;
            this.clcikcount.Location = new System.Drawing.Point(736, 9);
            this.clcikcount.Name = "clcikcount";
            this.clcikcount.Size = new System.Drawing.Size(36, 37);
            this.clcikcount.TabIndex = 0;
            this.clcikcount.Text = "0";
            // 
            // Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoJiPuzzle.Properties.Resources.배경;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clcikcount);
            this.Name = "Solution";
            this.Text = "Solution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solution_FormClosing);
            this.Load += new System.EventHandler(this.Solution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clcikcount;
    }
}