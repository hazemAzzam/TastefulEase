namespace TestefulEase.UserControls.Payements
{
    partial class PaymentItemControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDateLbl = new System.Windows.Forms.Label();
            this.numberOfItemsLbl = new System.Windows.Forms.Label();
            this.totalPaymentsLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 171);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(17, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 18);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(535, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 153);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(17, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 18);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Payment:";
            // 
            // orderDateLbl
            // 
            this.orderDateLbl.AutoSize = true;
            this.orderDateLbl.Location = new System.Drawing.Point(157, 32);
            this.orderDateLbl.Name = "orderDateLbl";
            this.orderDateLbl.Size = new System.Drawing.Size(90, 21);
            this.orderDateLbl.TabIndex = 8;
            this.orderDateLbl.Text = "Order Date:";
            // 
            // numberOfItemsLbl
            // 
            this.numberOfItemsLbl.AutoSize = true;
            this.numberOfItemsLbl.Location = new System.Drawing.Point(157, 72);
            this.numberOfItemsLbl.Name = "numberOfItemsLbl";
            this.numberOfItemsLbl.Size = new System.Drawing.Size(90, 21);
            this.numberOfItemsLbl.TabIndex = 9;
            this.numberOfItemsLbl.Text = "Order Date:";
            // 
            // totalPaymentsLbl
            // 
            this.totalPaymentsLbl.AutoSize = true;
            this.totalPaymentsLbl.Location = new System.Drawing.Point(157, 117);
            this.totalPaymentsLbl.Name = "totalPaymentsLbl";
            this.totalPaymentsLbl.Size = new System.Drawing.Size(90, 21);
            this.totalPaymentsLbl.TabIndex = 10;
            this.totalPaymentsLbl.Text = "Order Date:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(399, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 106);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPaymentsLbl);
            this.Controls.Add(this.numberOfItemsLbl);
            this.Controls.Add(this.orderDateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(112)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentItemControl";
            this.Size = new System.Drawing.Size(552, 171);
            this.Load += new System.EventHandler(this.PaymentItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label orderDateLbl;
        private Label numberOfItemsLbl;
        private Label totalPaymentsLbl;
        private Button button1;
    }
}
