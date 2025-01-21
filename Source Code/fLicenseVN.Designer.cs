namespace Calculator
{
    partial class fLicenseVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLicenseVN));
            panel1 = new Panel();
            linkWeb = new LinkLabel();
            btnDong = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkWeb);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 3;
            // 
            // linkWeb
            // 
            linkWeb.AutoSize = true;
            linkWeb.LinkBehavior = LinkBehavior.HoverUnderline;
            linkWeb.Location = new Point(159, 164);
            linkWeb.Name = "linkWeb";
            linkWeb.Size = new Size(63, 15);
            linkWeb.TabIndex = 6;
            linkWeb.TabStop = true;
            linkWeb.Text = "Trang Web";
            linkWeb.LinkClicked += linkWeb_LinkClicked;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(285, 211);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 23);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Green;
            label4.Location = new Point(198, 139);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 4;
            label4.Text = "Đã Kích Hoạt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 139);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 3;
            label3.Text = "Trạng Thái Bản Quyền:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(117, 77);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 0;
            label1.Text = "Máy Tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 114);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Phiên Bản 1.0";
            // 
            // fLisenceVN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 229, 253);
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "fLisenceVN";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bản Quyền";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkWeb;
        private Button btnDong;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}