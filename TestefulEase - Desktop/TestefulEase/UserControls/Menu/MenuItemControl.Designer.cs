namespace TestefulEase.UserControls
{
    partial class MenuItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemControl));
            this.itemImg = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemOrder = new System.Windows.Forms.Button();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.itemOrderBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImg
            // 
            this.itemImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemImg.Location = new System.Drawing.Point(0, 0);
            this.itemImg.Name = "itemImg";
            this.itemImg.Size = new System.Drawing.Size(204, 189);
            this.itemImg.TabIndex = 0;
            this.itemImg.TabStop = false;
            // 
            // itemName
            // 
            this.itemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemName.Location = new System.Drawing.Point(0, 189);
            this.itemName.Multiline = true;
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(204, 23);
            this.itemName.TabIndex = 1;
            // 
            // itemOrder
            // 
            this.itemOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemOrder.Location = new System.Drawing.Point(0, 300);
            this.itemOrder.Name = "itemOrder";
            this.itemOrder.Size = new System.Drawing.Size(204, 34);
            this.itemOrder.TabIndex = 2;
            this.itemOrder.Text = "button1";
            this.itemOrder.UseVisualStyleBackColor = true;
            // 
            // itemDescription
            // 
            this.itemDescription.Location = new System.Drawing.Point(0, 0);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(100, 23);
            this.itemDescription.TabIndex = 0;
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemPictureBox.Location = new System.Drawing.Point(0, 0);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(225, 303);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 0;
            this.itemPictureBox.TabStop = false;
            // 
            // itemOrderBtn
            // 
            this.itemOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.itemOrderBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemOrderBtn.FlatAppearance.BorderSize = 0;
            this.itemOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemOrderBtn.ForeColor = System.Drawing.Color.White;
            this.itemOrderBtn.Location = new System.Drawing.Point(225, 260);
            this.itemOrderBtn.Name = "itemOrderBtn";
            this.itemOrderBtn.Size = new System.Drawing.Size(328, 43);
            this.itemOrderBtn.TabIndex = 3;
            this.itemOrderBtn.Text = "Order";
            this.itemOrderBtn.UseVisualStyleBackColor = false;
            this.itemOrderBtn.Click += new System.EventHandler(this.itemOrderBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(225, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 102);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(410, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(341, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(390, 215);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(17, 20);
            this.quantity.TabIndex = 12;
            this.quantity.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantity:";
            // 
            // MenuItemControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.itemOrderBtn);
            this.Controls.Add(this.itemPictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(553, 303);
            this.Load += new System.EventHandler(this.MenuItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox itemImg;
        private TextBox itemName;
        private Button itemOrder;
        private TextBox itemDescription;
        private PictureBox itemPictureBox;
        private Button itemOrderBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label quantity;
    }
}
