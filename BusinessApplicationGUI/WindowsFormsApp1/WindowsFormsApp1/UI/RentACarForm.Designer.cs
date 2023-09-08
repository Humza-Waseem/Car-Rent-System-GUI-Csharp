
namespace WindowsFormsApp1.UI
{
    partial class RentACarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDays = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPromo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(189, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 88);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rent A Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(201, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Car Name";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbName.ForeColor = System.Drawing.Color.White;
            this.txbName.Location = new System.Drawing.Point(316, 129);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(216, 20);
            this.txbName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(205, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter Company";
            // 
            // txbCompany
            // 
            this.txbCompany.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbCompany.ForeColor = System.Drawing.Color.White;
            this.txbCompany.Location = new System.Drawing.Point(316, 172);
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.Size = new System.Drawing.Size(216, 20);
            this.txbCompany.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(159, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "EnterDaysYouWantToKeep";
            // 
            // txbDays
            // 
            this.txbDays.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbDays.ForeColor = System.Drawing.Color.White;
            this.txbDays.Location = new System.Drawing.Point(316, 209);
            this.txbDays.Name = "txbDays";
            this.txbDays.Size = new System.Drawing.Size(216, 20);
            this.txbDays.TabIndex = 23;
            this.txbDays.TextChanged += new System.EventHandler(this.txbDays_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EnterButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EnterButton.Location = new System.Drawing.Point(457, 291);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 24;
            this.EnterButton.Text = "ENTER";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(316, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbPromo
            // 
            this.txbPromo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbPromo.ForeColor = System.Drawing.Color.White;
            this.txbPromo.Location = new System.Drawing.Point(316, 250);
            this.txbPromo.Name = "txbPromo";
            this.txbPromo.Size = new System.Drawing.Size(216, 20);
            this.txbPromo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(205, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter Promo*";
            // 
            // RentACarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._154c31e91e05feaa25c11021b518fd67;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPromo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.txbDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "RentACarForm";
            this.Text = "RentACarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDays;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPromo;
        private System.Windows.Forms.Label label5;
    }
}