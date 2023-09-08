
namespace WindowsFormsApp1.UI
{
    partial class RentedCarsMenu
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
            this.RentedDataGrid = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RentedDataGrid
            // 
            this.RentedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentedDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RentedDataGrid.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.RentedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedDataGrid.Location = new System.Drawing.Point(89, 116);
            this.RentedDataGrid.Name = "RentedDataGrid";
            this.RentedDataGrid.Size = new System.Drawing.Size(607, 257);
            this.RentedDataGrid.TabIndex = 0;
            this.RentedDataGrid.Visible = false;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.Navy;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Show.Location = new System.Drawing.Point(321, 388);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(114, 31);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(169, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 79);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rented Cars";
            // 
            // RentedCarsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._81d462ecaa037ec34080fd4ee9a58b9b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.RentedDataGrid);
            this.Name = "RentedCarsMenu";
            this.Text = "RentedCarsMenu";
            this.Load += new System.EventHandler(this.RentedCarsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RentedDataGrid;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label label3;
    }
}