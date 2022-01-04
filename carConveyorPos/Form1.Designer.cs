namespace carConveyorPos
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plcPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plcIp = new System.Windows.Forms.TextBox();
            this.plcRack = new System.Windows.Forms.TextBox();
            this.plcSlot = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readingStation = new System.Windows.Forms.Button();
            this.Rone = new System.Windows.Forms.Button();
            this.Rtwo = new System.Windows.Forms.Button();
            this.Rthree = new System.Windows.Forms.Button();
            this.Rfour = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rollerNum = new System.Windows.Forms.TextBox();
            this.carNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RRone = new System.Windows.Forms.TextBox();
            this.RRtwo = new System.Windows.Forms.TextBox();
            this.RRthree = new System.Windows.Forms.TextBox();
            this.RRfour = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.carIn = new System.Windows.Forms.TextBox();
            this.Oone = new System.Windows.Forms.Button();
            this.Otwo = new System.Windows.Forms.Button();
            this.Othree = new System.Windows.Forms.Button();
            this.Ofour = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sendOne = new System.Windows.Forms.Label();
            this.sendTwo = new System.Windows.Forms.Label();
            this.sendThree = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RonePic = new System.Windows.Forms.PictureBox();
            this.RtwoPic = new System.Windows.Forms.PictureBox();
            this.RthreePic = new System.Windows.Forms.PictureBox();
            this.RfourPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plcPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RonePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtwoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RthreePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RfourPic)).BeginInit();
            this.SuspendLayout();
            // 
            // plcPic
            // 
            this.plcPic.Image = ((System.Drawing.Image)(resources.GetObject("plcPic.Image")));
            this.plcPic.Location = new System.Drawing.Point(6, 37);
            this.plcPic.Name = "plcPic";
            this.plcPic.Size = new System.Drawing.Size(150, 90);
            this.plcPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plcPic.TabIndex = 0;
            this.plcPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rack：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slot：";
            // 
            // plcIp
            // 
            this.plcIp.Location = new System.Drawing.Point(214, 37);
            this.plcIp.Name = "plcIp";
            this.plcIp.Size = new System.Drawing.Size(116, 25);
            this.plcIp.TabIndex = 4;
            // 
            // plcRack
            // 
            this.plcRack.Location = new System.Drawing.Point(214, 67);
            this.plcRack.Name = "plcRack";
            this.plcRack.Size = new System.Drawing.Size(32, 25);
            this.plcRack.TabIndex = 5;
            // 
            // plcSlot
            // 
            this.plcSlot.Location = new System.Drawing.Point(214, 98);
            this.plcSlot.Name = "plcSlot";
            this.plcSlot.Size = new System.Drawing.Size(32, 25);
            this.plcSlot.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plcPic);
            this.groupBox1.Controls.Add(this.plcSlot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.plcRack);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.plcIp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC信息";
            // 
            // readingStation
            // 
            this.readingStation.Location = new System.Drawing.Point(240, 222);
            this.readingStation.Name = "readingStation";
            this.readingStation.Size = new System.Drawing.Size(75, 34);
            this.readingStation.TabIndex = 8;
            this.readingStation.Text = "读写站";
            this.readingStation.UseVisualStyleBackColor = true;
            // 
            // Rone
            // 
            this.Rone.Location = new System.Drawing.Point(240, 257);
            this.Rone.Name = "Rone";
            this.Rone.Size = new System.Drawing.Size(75, 31);
            this.Rone.TabIndex = 9;
            this.Rone.Text = "RB005";
            this.Rone.UseVisualStyleBackColor = true;
            // 
            // Rtwo
            // 
            this.Rtwo.Location = new System.Drawing.Point(334, 257);
            this.Rtwo.Name = "Rtwo";
            this.Rtwo.Size = new System.Drawing.Size(75, 31);
            this.Rtwo.TabIndex = 10;
            this.Rtwo.Text = "RB010";
            this.Rtwo.UseVisualStyleBackColor = true;
            // 
            // Rthree
            // 
            this.Rthree.Location = new System.Drawing.Point(435, 257);
            this.Rthree.Name = "Rthree";
            this.Rthree.Size = new System.Drawing.Size(75, 31);
            this.Rthree.TabIndex = 11;
            this.Rthree.Text = "RB015";
            this.Rthree.UseVisualStyleBackColor = true;
            // 
            // Rfour
            // 
            this.Rfour.Location = new System.Drawing.Point(528, 257);
            this.Rfour.Name = "Rfour";
            this.Rfour.Size = new System.Drawing.Size(75, 31);
            this.Rfour.TabIndex = 12;
            this.Rfour.Text = "RB020";
            this.Rfour.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rollerNum);
            this.groupBox2.Controls.Add(this.carNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(423, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 156);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车身停留位置定义";
            // 
            // rollerNum
            // 
            this.rollerNum.Location = new System.Drawing.Point(104, 81);
            this.rollerNum.Name = "rollerNum";
            this.rollerNum.Size = new System.Drawing.Size(116, 25);
            this.rollerNum.TabIndex = 15;
            // 
            // carNum
            // 
            this.carNum.Location = new System.Drawing.Point(104, 37);
            this.carNum.Name = "carNum";
            this.carNum.Size = new System.Drawing.Size(116, 25);
            this.carNum.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "停留车身号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "停留滚床编号：";
            // 
            // RRone
            // 
            this.RRone.Location = new System.Drawing.Point(240, 294);
            this.RRone.Name = "RRone";
            this.RRone.Size = new System.Drawing.Size(75, 25);
            this.RRone.TabIndex = 14;
            this.RRone.TextChanged += new System.EventHandler(this.RRone_TextChanged);
            // 
            // RRtwo
            // 
            this.RRtwo.Location = new System.Drawing.Point(334, 294);
            this.RRtwo.Name = "RRtwo";
            this.RRtwo.Size = new System.Drawing.Size(75, 25);
            this.RRtwo.TabIndex = 15;
            this.RRtwo.TextChanged += new System.EventHandler(this.RRtwo_TextChanged);
            // 
            // RRthree
            // 
            this.RRthree.Location = new System.Drawing.Point(435, 294);
            this.RRthree.Name = "RRthree";
            this.RRthree.Size = new System.Drawing.Size(75, 25);
            this.RRthree.TabIndex = 16;
            this.RRthree.TextChanged += new System.EventHandler(this.RRthree_TextChanged);
            // 
            // RRfour
            // 
            this.RRfour.Location = new System.Drawing.Point(529, 294);
            this.RRfour.Name = "RRfour";
            this.RRfour.Size = new System.Drawing.Size(75, 25);
            this.RRfour.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.carIn);
            this.groupBox3.Location = new System.Drawing.Point(23, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "模拟来车信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "信息来自PLC";
            // 
            // carIn
            // 
            this.carIn.Location = new System.Drawing.Point(16, 42);
            this.carIn.Name = "carIn";
            this.carIn.Size = new System.Drawing.Size(75, 25);
            this.carIn.TabIndex = 19;
            // 
            // Oone
            // 
            this.Oone.Location = new System.Drawing.Point(240, 346);
            this.Oone.Name = "Oone";
            this.Oone.Size = new System.Drawing.Size(75, 23);
            this.Oone.TabIndex = 19;
            this.Oone.Text = "占位";
            this.Oone.UseVisualStyleBackColor = true;
            this.Oone.Click += new System.EventHandler(this.Oone_Click);
            // 
            // Otwo
            // 
            this.Otwo.Location = new System.Drawing.Point(334, 346);
            this.Otwo.Name = "Otwo";
            this.Otwo.Size = new System.Drawing.Size(75, 23);
            this.Otwo.TabIndex = 20;
            this.Otwo.Text = "占位";
            this.Otwo.UseVisualStyleBackColor = true;
            this.Otwo.Click += new System.EventHandler(this.Otwo_Click);
            // 
            // Othree
            // 
            this.Othree.Location = new System.Drawing.Point(439, 346);
            this.Othree.Name = "Othree";
            this.Othree.Size = new System.Drawing.Size(71, 23);
            this.Othree.TabIndex = 21;
            this.Othree.Text = "占位";
            this.Othree.UseVisualStyleBackColor = true;
            this.Othree.Click += new System.EventHandler(this.Othree_Click);
            // 
            // Ofour
            // 
            this.Ofour.Location = new System.Drawing.Point(529, 346);
            this.Ofour.Name = "Ofour";
            this.Ofour.Size = new System.Drawing.Size(74, 23);
            this.Ofour.TabIndex = 22;
            this.Ofour.Text = "占位";
            this.Ofour.UseVisualStyleBackColor = true;
            this.Ofour.Click += new System.EventHandler(this.Ofour_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sendOne
            // 
            this.sendOne.AutoSize = true;
            this.sendOne.Location = new System.Drawing.Point(237, 376);
            this.sendOne.Name = "sendOne";
            this.sendOne.Size = new System.Drawing.Size(0, 15);
            this.sendOne.TabIndex = 24;
            // 
            // sendTwo
            // 
            this.sendTwo.AutoSize = true;
            this.sendTwo.Location = new System.Drawing.Point(331, 376);
            this.sendTwo.Name = "sendTwo";
            this.sendTwo.Size = new System.Drawing.Size(0, 15);
            this.sendTwo.TabIndex = 25;
            // 
            // sendThree
            // 
            this.sendThree.AutoSize = true;
            this.sendThree.Location = new System.Drawing.Point(436, 376);
            this.sendThree.Name = "sendThree";
            this.sendThree.Size = new System.Drawing.Size(0, 15);
            this.sendThree.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "滚床编号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "车身FIS号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "滚床占位信号";
            // 
            // RonePic
            // 
            this.RonePic.Image = global::carConveyorPos.Properties.Resources.carModel;
            this.RonePic.Location = new System.Drawing.Point(231, 174);
            this.RonePic.Name = "RonePic";
            this.RonePic.Size = new System.Drawing.Size(100, 50);
            this.RonePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RonePic.TabIndex = 29;
            this.RonePic.TabStop = false;
            // 
            // RtwoPic
            // 
            this.RtwoPic.Image = global::carConveyorPos.Properties.Resources.carModel;
            this.RtwoPic.Location = new System.Drawing.Point(321, 206);
            this.RtwoPic.Name = "RtwoPic";
            this.RtwoPic.Size = new System.Drawing.Size(100, 50);
            this.RtwoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RtwoPic.TabIndex = 30;
            this.RtwoPic.TabStop = false;
            // 
            // RthreePic
            // 
            this.RthreePic.Image = global::carConveyorPos.Properties.Resources.carModel;
            this.RthreePic.Location = new System.Drawing.Point(423, 206);
            this.RthreePic.Name = "RthreePic";
            this.RthreePic.Size = new System.Drawing.Size(100, 50);
            this.RthreePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RthreePic.TabIndex = 31;
            this.RthreePic.TabStop = false;
            // 
            // RfourPic
            // 
            this.RfourPic.Image = global::carConveyorPos.Properties.Resources.carModel;
            this.RfourPic.Location = new System.Drawing.Point(518, 206);
            this.RfourPic.Name = "RfourPic";
            this.RfourPic.Size = new System.Drawing.Size(100, 50);
            this.RfourPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RfourPic.TabIndex = 32;
            this.RfourPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 409);
            this.Controls.Add(this.RfourPic);
            this.Controls.Add(this.RthreePic);
            this.Controls.Add(this.RtwoPic);
            this.Controls.Add(this.RonePic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sendThree);
            this.Controls.Add(this.sendTwo);
            this.Controls.Add(this.sendOne);
            this.Controls.Add(this.Ofour);
            this.Controls.Add(this.Othree);
            this.Controls.Add(this.Otwo);
            this.Controls.Add(this.Oone);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RRfour);
            this.Controls.Add(this.RRthree);
            this.Controls.Add(this.RRtwo);
            this.Controls.Add(this.RRone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Rfour);
            this.Controls.Add(this.Rthree);
            this.Controls.Add(this.Rtwo);
            this.Controls.Add(this.Rone);
            this.Controls.Add(this.readingStation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "车身停留在指定位置滚床上";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plcPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RonePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtwoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RthreePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RfourPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plcPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plcIp;
        private System.Windows.Forms.TextBox plcRack;
        private System.Windows.Forms.TextBox plcSlot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button readingStation;
        private System.Windows.Forms.Button Rone;
        private System.Windows.Forms.Button Rtwo;
        private System.Windows.Forms.Button Rthree;
        private System.Windows.Forms.Button Rfour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rollerNum;
        private System.Windows.Forms.TextBox carNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RRone;
        private System.Windows.Forms.TextBox RRtwo;
        private System.Windows.Forms.TextBox RRthree;
        private System.Windows.Forms.TextBox RRfour;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox carIn;
        private System.Windows.Forms.Button Oone;
        private System.Windows.Forms.Button Otwo;
        private System.Windows.Forms.Button Othree;
        private System.Windows.Forms.Button Ofour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sendOne;
        private System.Windows.Forms.Label sendTwo;
        private System.Windows.Forms.Label sendThree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox RonePic;
        private System.Windows.Forms.PictureBox RtwoPic;
        private System.Windows.Forms.PictureBox RthreePic;
        private System.Windows.Forms.PictureBox RfourPic;
    }
}

