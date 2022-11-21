namespace nPuzzle
{
    partial class puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(puzzle));
            this.label1 = new System.Windows.Forms.Label();
            this.winimg = new System.Windows.Forms.PictureBox();
            this.wincom2 = new System.Windows.Forms.Label();
            this.winimg2 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Countbox = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.backlabel = new System.Windows.Forms.Label();
            this.restratbtn = new System.Windows.Forms.PictureBox();
            this.restartlabel = new System.Windows.Forms.Label();
            this.solBtn = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.Label();
            this.NoBtn = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Label();
            this.wingif = new System.Windows.Forms.PictureBox();
            this.sollabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restratbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wingif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("둥근모꼴", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "nxn Puzzle Game";
            // 
            // winimg
            // 
            this.winimg.BackColor = System.Drawing.Color.Transparent;
            this.winimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.winimg.Image = ((System.Drawing.Image)(resources.GetObject("winimg.Image")));
            this.winimg.Location = new System.Drawing.Point(254, 125);
            this.winimg.Name = "winimg";
            this.winimg.Size = new System.Drawing.Size(199, 201);
            this.winimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winimg.TabIndex = 5;
            this.winimg.TabStop = false;
            // 
            // wincom2
            // 
            this.wincom2.AutoSize = true;
            this.wincom2.BackColor = System.Drawing.Color.Transparent;
            this.wincom2.Font = new System.Drawing.Font("둥근모꼴", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wincom2.ForeColor = System.Drawing.Color.White;
            this.wincom2.Location = new System.Drawing.Point(232, 335);
            this.wincom2.Name = "wincom2";
            this.wincom2.Size = new System.Drawing.Size(248, 19);
            this.wincom2.TabIndex = 8;
            this.wincom2.Text = "순위를 확인 하시겠습니까?";
            // 
            // winimg2
            // 
            this.winimg2.BackColor = System.Drawing.Color.Transparent;
            this.winimg2.Image = ((System.Drawing.Image)(resources.GetObject("winimg2.Image")));
            this.winimg2.Location = new System.Drawing.Point(12, 6);
            this.winimg2.Name = "winimg2";
            this.winimg2.Size = new System.Drawing.Size(769, 449);
            this.winimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winimg2.TabIndex = 22;
            this.winimg2.TabStop = false;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.BackColor = System.Drawing.Color.Transparent;
            this.Count.Font = new System.Drawing.Font("둥근모꼴", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Count.ForeColor = System.Drawing.Color.Gold;
            this.Count.Location = new System.Drawing.Point(120, 17);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(44, 48);
            this.Count.TabIndex = 23;
            this.Count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("둥근모꼴", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Click:";
            // 
            // Countbox
            // 
            this.Countbox.Location = new System.Drawing.Point(762, 432);
            this.Countbox.Multiline = true;
            this.Countbox.Name = "Countbox";
            this.Countbox.Size = new System.Drawing.Size(10, 23);
            this.Countbox.TabIndex = 17;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.Location = new System.Drawing.Point(663, 273);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(66, 72);
            this.savebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.savebtn.TabIndex = 25;
            this.savebtn.TabStop = false;
            this.savebtn.Click += new System.EventHandler(this.pictureBox1_Click);
            this.savebtn.MouseEnter += new System.EventHandler(this.savebtn_MouseEnter);
            this.savebtn.MouseLeave += new System.EventHandler(this.savebtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(671, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "저장";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.Location = new System.Drawing.Point(652, 357);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(64, 74);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtn.TabIndex = 27;
            this.exitbtn.TabStop = false;
            this.exitbtn.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.exitbtn.MouseEnter += new System.EventHandler(this.exitbtn_MouseEnter);
            this.exitbtn.MouseLeave += new System.EventHandler(this.exitbtn_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(671, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "나가기";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(663, 91);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(66, 72);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 29;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            this.backbtn.MouseEnter += new System.EventHandler(this.backbtn_MouseEnter);
            this.backbtn.MouseLeave += new System.EventHandler(this.backbtn_MouseLeave);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backlabel.ForeColor = System.Drawing.Color.White;
            this.backlabel.Location = new System.Drawing.Point(659, 151);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(94, 21);
            this.backlabel.TabIndex = 30;
            this.backlabel.Text = "돌아가기";
            this.backlabel.Click += new System.EventHandler(this.backlabel_Click);
            // 
            // restratbtn
            // 
            this.restratbtn.BackColor = System.Drawing.Color.Transparent;
            this.restratbtn.Image = ((System.Drawing.Image)(resources.GetObject("restratbtn.Image")));
            this.restratbtn.Location = new System.Drawing.Point(639, 165);
            this.restratbtn.Name = "restratbtn";
            this.restratbtn.Size = new System.Drawing.Size(105, 102);
            this.restratbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restratbtn.TabIndex = 31;
            this.restratbtn.TabStop = false;
            this.restratbtn.Click += new System.EventHandler(this.restratbtn_Click);
            this.restratbtn.MouseEnter += new System.EventHandler(this.restratbtn_MouseEnter);
            this.restratbtn.MouseLeave += new System.EventHandler(this.restratbtn_MouseLeave);
            // 
            // restartlabel
            // 
            this.restartlabel.AutoSize = true;
            this.restartlabel.BackColor = System.Drawing.Color.Transparent;
            this.restartlabel.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.restartlabel.ForeColor = System.Drawing.Color.White;
            this.restartlabel.Location = new System.Drawing.Point(659, 238);
            this.restartlabel.Name = "restartlabel";
            this.restartlabel.Size = new System.Drawing.Size(94, 23);
            this.restartlabel.TabIndex = 32;
            this.restartlabel.Text = "재시작 ";
            this.restartlabel.Click += new System.EventHandler(this.restartlabel_Click);
            // 
            // solBtn
            // 
            this.solBtn.BackColor = System.Drawing.Color.Transparent;
            this.solBtn.Image = ((System.Drawing.Image)(resources.GetObject("solBtn.Image")));
            this.solBtn.Location = new System.Drawing.Point(663, 9);
            this.solBtn.Name = "solBtn";
            this.solBtn.Size = new System.Drawing.Size(66, 76);
            this.solBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solBtn.TabIndex = 33;
            this.solBtn.TabStop = false;
            this.solBtn.Click += new System.EventHandler(this.solBtn_Click);
            this.solBtn.MouseEnter += new System.EventHandler(this.solBtn_MouseEnter);
            this.solBtn.MouseLeave += new System.EventHandler(this.solBtn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(659, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "솔루션!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.BackColor = System.Drawing.Color.Transparent;
            this.usrname.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usrname.ForeColor = System.Drawing.Color.White;
            this.usrname.Location = new System.Drawing.Point(535, 17);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(106, 23);
            this.usrname.TabIndex = 21;
            this.usrname.Text = "넴유저닉";
            // 
            // NoBtn
            // 
            this.NoBtn.AutoSize = true;
            this.NoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoBtn.Font = new System.Drawing.Font("둥근모꼴", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NoBtn.ForeColor = System.Drawing.Color.White;
            this.NoBtn.Location = new System.Drawing.Point(412, 367);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(58, 41);
            this.NoBtn.TabIndex = 35;
            this.NoBtn.Text = "No";
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            this.NoBtn.MouseEnter += new System.EventHandler(this.NoBtn_MouseEnter);
            this.NoBtn.MouseLeave += new System.EventHandler(this.NoBtn_MouseLeave);
            // 
            // YesBtn
            // 
            this.YesBtn.AutoSize = true;
            this.YesBtn.BackColor = System.Drawing.Color.Transparent;
            this.YesBtn.Font = new System.Drawing.Font("둥근모꼴", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YesBtn.ForeColor = System.Drawing.Color.White;
            this.YesBtn.Location = new System.Drawing.Point(238, 367);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(78, 41);
            this.YesBtn.TabIndex = 36;
            this.YesBtn.Text = "Yes";
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            this.YesBtn.MouseEnter += new System.EventHandler(this.YesBtn_MouseEnter);
            this.YesBtn.MouseLeave += new System.EventHandler(this.YesBtn_MouseLeave);
            // 
            // wingif
            // 
            this.wingif.BackColor = System.Drawing.Color.Transparent;
            this.wingif.Image = ((System.Drawing.Image)(resources.GetObject("wingif.Image")));
            this.wingif.Location = new System.Drawing.Point(12, 6);
            this.wingif.Name = "wingif";
            this.wingif.Size = new System.Drawing.Size(760, 449);
            this.wingif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wingif.TabIndex = 37;
            this.wingif.TabStop = false;
            // 
            // sollabel2
            // 
            this.sollabel2.AutoSize = true;
            this.sollabel2.BackColor = System.Drawing.Color.Transparent;
            this.sollabel2.Font = new System.Drawing.Font("둥근모꼴", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sollabel2.ForeColor = System.Drawing.Color.White;
            this.sollabel2.Location = new System.Drawing.Point(735, 9);
            this.sollabel2.Name = "sollabel2";
            this.sollabel2.Size = new System.Drawing.Size(34, 23);
            this.sollabel2.TabIndex = 38;
            this.sollabel2.Text = "?!";
            // 
            // puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::DoJiPuzzle.Properties.Resources.배경;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.sollabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.solBtn);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.restartlabel);
            this.Controls.Add(this.restratbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.wincom2);
            this.Controls.Add(this.winimg);
            this.Controls.Add(this.Countbox);
            this.Controls.Add(this.wingif);
            this.Controls.Add(this.winimg2);
            this.DoubleBuffered = true;
            this.Name = "puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "도지의 퍼즐게임";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Puzzle_FormClosing);
            this.Load += new System.EventHandler(this.Puzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restratbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wingif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox winimg;
        private System.Windows.Forms.Label wincom2;
        private System.Windows.Forms.PictureBox winimg2;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Countbox;
        private System.Windows.Forms.PictureBox savebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.PictureBox restratbtn;
        private System.Windows.Forms.Label restartlabel;
        private System.Windows.Forms.PictureBox solBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Label NoBtn;
        private System.Windows.Forms.Label YesBtn;
        private System.Windows.Forms.PictureBox wingif;
        private System.Windows.Forms.Label sollabel2;
    }
}

