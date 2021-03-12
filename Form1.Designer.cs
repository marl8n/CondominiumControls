
namespace CondominiumControls
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrderByFee = new System.Windows.Forms.Button();
            this.btnMostProperties = new System.Windows.Forms.Button();
            this.btnByMantainanceTop = new System.Windows.Forms.Button();
            this.btnOrderByMaintainanceBottom = new System.Windows.Forms.Button();
            this.btnMostMantainanceFee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOrderByFee
            // 
            this.btnOrderByFee.Location = new System.Drawing.Point(41, 13);
            this.btnOrderByFee.Name = "btnOrderByFee";
            this.btnOrderByFee.Size = new System.Drawing.Size(108, 23);
            this.btnOrderByFee.TabIndex = 1;
            this.btnOrderByFee.Text = "Order by fee";
            this.btnOrderByFee.UseVisualStyleBackColor = true;
            this.btnOrderByFee.Click += new System.EventHandler(this.btnOrderByFee_Click);
            // 
            // btnMostProperties
            // 
            this.btnMostProperties.Location = new System.Drawing.Point(174, 13);
            this.btnMostProperties.Name = "btnMostProperties";
            this.btnMostProperties.Size = new System.Drawing.Size(123, 23);
            this.btnMostProperties.TabIndex = 2;
            this.btnMostProperties.Text = "Most Properties";
            this.btnMostProperties.UseVisualStyleBackColor = true;
            this.btnMostProperties.Click += new System.EventHandler(this.btnMostProperties_Click);
            // 
            // btnByMantainanceTop
            // 
            this.btnByMantainanceTop.Location = new System.Drawing.Point(319, 13);
            this.btnByMantainanceTop.Name = "btnByMantainanceTop";
            this.btnByMantainanceTop.Size = new System.Drawing.Size(145, 23);
            this.btnByMantainanceTop.TabIndex = 3;
            this.btnByMantainanceTop.Text = "By mantainance ⬆";
            this.btnByMantainanceTop.UseVisualStyleBackColor = true;
            this.btnByMantainanceTop.Click += new System.EventHandler(this.btnByMantainanceTop_Click);
            // 
            // btnOrderByMaintainanceBottom
            // 
            this.btnOrderByMaintainanceBottom.Location = new System.Drawing.Point(481, 13);
            this.btnOrderByMaintainanceBottom.Name = "btnOrderByMaintainanceBottom";
            this.btnOrderByMaintainanceBottom.Size = new System.Drawing.Size(136, 23);
            this.btnOrderByMaintainanceBottom.TabIndex = 4;
            this.btnOrderByMaintainanceBottom.Text = "By mantainance ⬇";
            this.btnOrderByMaintainanceBottom.UseVisualStyleBackColor = true;
            this.btnOrderByMaintainanceBottom.Click += new System.EventHandler(this.btnOrderByMaintainanceBottom_Click);
            // 
            // btnMostMantainanceFee
            // 
            this.btnMostMantainanceFee.Location = new System.Drawing.Point(624, 12);
            this.btnMostMantainanceFee.Name = "btnMostMantainanceFee";
            this.btnMostMantainanceFee.Size = new System.Drawing.Size(145, 23);
            this.btnMostMantainanceFee.TabIndex = 6;
            this.btnMostMantainanceFee.Text = "Most Mantainance";
            this.btnMostMantainanceFee.UseVisualStyleBackColor = true;
            this.btnMostMantainanceFee.Click += new System.EventHandler(this.btnMostMantainanceFee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostMantainanceFee);
            this.Controls.Add(this.btnOrderByMaintainanceBottom);
            this.Controls.Add(this.btnByMantainanceTop);
            this.Controls.Add(this.btnMostProperties);
            this.Controls.Add(this.btnOrderByFee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOrderByFee;
        private System.Windows.Forms.Button btnMostProperties;
        private System.Windows.Forms.Button btnByMantainanceTop;
        private System.Windows.Forms.Button btnOrderByMaintainanceBottom;
        private System.Windows.Forms.Button btnMostMantainanceFee;
    }
}

