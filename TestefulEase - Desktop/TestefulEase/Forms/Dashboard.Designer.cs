namespace TestefulEase.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 595);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(3, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "My Payments";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "My Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.customerNameLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 38);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(543, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 38);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerNameLbl.Location = new System.Drawing.Point(6, 8);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(63, 25);
            this.customerNameLbl.TabIndex = 0;
            this.customerNameLbl.Text = "label1";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.container.Location = new System.Drawing.Point(236, 38);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(578, 557);
            this.container.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(797, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 557);
            this.panel4.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(814, 595);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "FixDashBoard";
            this.Load += new System.EventHandler(this.FixDashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label customerNameLbl;
        private Panel container;
        private Panel panel4;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
    }
}