
namespace WindowsFormsApp1.UI
{
    partial class RemoveCars
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
            this.label4 = new System.Windows.Forms.Label();
            this.txbCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(218, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 59);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remove Cars";
            // 
            // txbCarName
            // 
            this.txbCarName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbCarName.ForeColor = System.Drawing.SystemColors.Window;
            this.txbCarName.Location = new System.Drawing.Point(254, 157);
            this.txbCarName.Name = "txbCarName";
            this.txbCarName.Size = new System.Drawing.Size(216, 20);
            this.txbCarName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(124, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Car Name";
            // 
            // txbCompany
            // 
            this.txbCompany.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbCompany.ForeColor = System.Drawing.SystemColors.Window;
            this.txbCompany.Location = new System.Drawing.Point(254, 212);
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.Size = new System.Drawing.Size(216, 20);
            this.txbCompany.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(128, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Company";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CarsTwo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCarName);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "RemoveCars";
            this.Text = "RemoveCars";
            this.Load += new System.EventHandler(this.RemoveCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}