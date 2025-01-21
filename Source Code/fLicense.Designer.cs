namespace Calculator
{
    partial class fLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLicense));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            btnExit = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(117, 77);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 114);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0";
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(159, 164);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Website";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(285, 211);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Green;
            label4.Location = new Point(191, 140);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Activated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 140);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "License State:";
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
            // fLicense
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
            Name = "fLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "License";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}