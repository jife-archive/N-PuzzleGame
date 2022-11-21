namespace nPuzzle
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NameCheck = new System.Windows.Forms.Label();
            this.NameYes = new System.Windows.Forms.Label();
            this.nameNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.BackColor = System.Drawing.Color.MidnightBlue;
            this.Namebox.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Namebox.ForeColor = System.Drawing.Color.White;
            this.Namebox.Location = new System.Drawing.Point(267, 302);
            this.Namebox.Multiline = true;
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(243, 35);
            this.Namebox.TabIndex = 1;
            this.Namebox.Text = "닉네임을 입력하시오.";
            this.Namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Namebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Namebox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 463);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 235);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(620, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
          
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.BackColor = System.Drawing.Color.Transparent;
            this.NameCheck.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameCheck.ForeColor = System.Drawing.Color.White;
            this.NameCheck.Location = new System.Drawing.Point(272, 262);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(226, 23);
            this.NameCheck.TabIndex = 8;
            this.NameCheck.Text = "ㅁㅁㅁ이 맞습니까?";
            // 
            // NameYes
            // 
            this.NameYes.AutoSize = true;
            this.NameYes.BackColor = System.Drawing.Color.Transparent;
            this.NameYes.Font = new System.Drawing.Font("둥근모꼴", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameYes.ForeColor = System.Drawing.Color.White;
            this.NameYes.Location = new System.Drawing.Point(292, 318);
            this.NameYes.Name = "NameYes";
            this.NameYes.Size = new System.Drawing.Size(38, 19);
            this.NameYes.TabIndex = 10;
            this.NameYes.Text = "네!";
            this.NameYes.Click += new System.EventHandler(this.NameYes_Click);
            // 
            // nameNo
            // 
            this.nameNo.AutoSize = true;
            this.nameNo.BackColor = System.Drawing.Color.Transparent;
            this.nameNo.Font = new System.Drawing.Font("둥근모꼴", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameNo.ForeColor = System.Drawing.Color.White;
            this.nameNo.Location = new System.Drawing.Point(422, 318);
            this.nameNo.Name = "nameNo";
            this.nameNo.Size = new System.Drawing.Size(76, 19);
            this.nameNo.TabIndex = 11;
            this.nameNo.Text = "아니오.";
            this.nameNo.Click += new System.EventHandler(this.nameNo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.nameNo);
            this.Controls.Add(this.NameYes);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.Text = "도지의 퍼즐게임";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NameCheck;
        private System.Windows.Forms.Label NameYes;
        private System.Windows.Forms.Label nameNo;
    }
}