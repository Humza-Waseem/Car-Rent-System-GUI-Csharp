
namespace WindowsFormsApp1.UI
{
    partial class ShowBillForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCarName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDays = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 88);
            this.label3.TabIndex = 18;
            this.label3.Text = "Costumer Bill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._7282663b3d6703043ac2b3643ee5bbc1;
            this.pictureBox1.Location = new System.Drawing.Point(215, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 288);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(321, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Print Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Black;
            this.Price.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Price.Location = new System.Drawing.Point(239, 317);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(58, 16);
            this.Price.TabIndex = 21;
            this.Price.Text = "Price :";
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.Maroon;
            this.txbPrice.ForeColor = System.Drawing.Color.White;
            this.txbPrice.Location = new System.Drawing.Point(337, 313);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(154, 20);
            this.txbPrice.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(239, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Car Name";
            // 
            // txbCarName
            // 
            this.txbCarName.BackColor = System.Drawing.Color.LightPink;
            this.txbCarName.ForeColor = System.Drawing.SystemColors.Window;
            this.txbCarName.Location = new System.Drawing.Point(337, 149);
            this.txbCarName.Name = "txbCarName";
            this.txbCarName.Size = new System.Drawing.Size(154, 20);
            this.txbCarName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(239, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Days";
            // 
            // txbDays
            // 
            this.txbDays.BackColor = System.Drawing.Color.LightPink;
            this.txbDays.ForeColor = System.Drawing.SystemColors.Window;
            this.txbDays.Location = new System.Drawing.Point(337, 210);
            this.txbDays.Name = "txbDays";
            this.txbDays.Size = new System.Drawing.Size(154, 20);
            this.txbDays.TabIndex = 29;
            // 
            // ShowBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aes1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "ShowBillForm";
            this.Text = "ShowBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDays;
    }
}