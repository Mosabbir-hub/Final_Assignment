
namespace Final_Assignment
{
    partial class Book_details
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
            this.labelBID = new System.Windows.Forms.Label();
            this.textBoxBId = new System.Windows.Forms.TextBox();
            this.textBoxAName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEdition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBID
            // 
            this.labelBID.AutoSize = true;
            this.labelBID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBID.Location = new System.Drawing.Point(273, 35);
            this.labelBID.Name = "labelBID";
            this.labelBID.Size = new System.Drawing.Size(39, 25);
            this.labelBID.TabIndex = 1;
            this.labelBID.Text = "ID:";
            // 
            // textBoxBId
            // 
            this.textBoxBId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBId.Location = new System.Drawing.Point(324, 32);
            this.textBoxBId.Name = "textBoxBId";
            this.textBoxBId.Size = new System.Drawing.Size(249, 32);
            this.textBoxBId.TabIndex = 2;
            // 
            // textBoxAName
            // 
            this.textBoxAName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAName.Location = new System.Drawing.Point(324, 127);
            this.textBoxAName.Name = "textBoxAName";
            this.textBoxAName.Size = new System.Drawing.Size(249, 32);
            this.textBoxAName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(236, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author:";
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdition.Location = new System.Drawing.Point(324, 169);
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.Size = new System.Drawing.Size(249, 32);
            this.textBoxEdition.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(228, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edition:";
            // 
            // textBoxBName
            // 
            this.textBoxBName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBName.Location = new System.Drawing.Point(324, 84);
            this.textBoxBName.Name = "textBoxBName";
            this.textBoxBName.Size = new System.Drawing.Size(249, 32);
            this.textBoxBName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(243, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 177);
            this.dataGridView1.TabIndex = 9;
            // 
            // Book_details
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBId);
            this.Controls.Add(this.labelBID);
            this.Name = "Book_details";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Book_details4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBID;
        private System.Windows.Forms.TextBox textBoxBId;
        private System.Windows.Forms.TextBox textBoxAName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEdition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}