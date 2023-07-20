
namespace BibliotekPL.VäljMedlemForm
{
    partial class Återlämna_VäljMedlem
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
            this.lbl_VäljMedlem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Fortsätt = new System.Windows.Forms.Button();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_VäljMedlem
            // 
            this.lbl_VäljMedlem.AutoSize = true;
            this.lbl_VäljMedlem.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_VäljMedlem.Location = new System.Drawing.Point(304, 86);
            this.lbl_VäljMedlem.Name = "lbl_VäljMedlem";
            this.lbl_VäljMedlem.Size = new System.Drawing.Size(171, 34);
            this.lbl_VäljMedlem.TabIndex = 0;
            this.lbl_VäljMedlem.Text = "Välj medlem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(557, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Fortsätt
            // 
            this.btn_Fortsätt.Location = new System.Drawing.Point(689, 391);
            this.btn_Fortsätt.Name = "btn_Fortsätt";
            this.btn_Fortsätt.Size = new System.Drawing.Size(94, 29);
            this.btn_Fortsätt.TabIndex = 2;
            this.btn_Fortsätt.Text = "Fortsätt";
            this.btn_Fortsätt.UseVisualStyleBackColor = true;
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(12, 391);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 3;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // Återlämna_VäljMedlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 432);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.btn_Fortsätt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_VäljMedlem);
            this.Name = "Återlämna_VäljMedlem";
            this.Text = "Återlämna_VäljMedlem";
            this.Load += new System.EventHandler(this.Återlämna_VäljMedlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VäljMedlem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Fortsätt;
        private System.Windows.Forms.Button btn_Tillbaka;
    }
}