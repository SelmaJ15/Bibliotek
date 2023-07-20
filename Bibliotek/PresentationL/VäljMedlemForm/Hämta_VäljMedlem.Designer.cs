
namespace BibliotekPL.VäljMedlemForm
{
    partial class Hämta_VäljMedlem
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
            this.label_väljMedlem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.btn_Forsätt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_väljMedlem
            // 
            this.label_väljMedlem.AutoSize = true;
            this.label_väljMedlem.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_väljMedlem.Location = new System.Drawing.Point(267, 77);
            this.label_väljMedlem.Name = "label_väljMedlem";
            this.label_väljMedlem.Size = new System.Drawing.Size(171, 34);
            this.label_väljMedlem.TabIndex = 0;
            this.label_väljMedlem.Text = "Välj medlem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(544, 188);
            this.dataGridView1.TabIndex = 1;
           
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(12, 388);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 2;
            this.btn_Tillbaka.Text = "<-Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // btn_Forsätt
            // 
            this.btn_Forsätt.Location = new System.Drawing.Point(620, 388);
            this.btn_Forsätt.Name = "btn_Forsätt";
            this.btn_Forsätt.Size = new System.Drawing.Size(94, 29);
            this.btn_Forsätt.TabIndex = 3;
            this.btn_Forsätt.Text = "Fortsätt";
            this.btn_Forsätt.UseVisualStyleBackColor = true;
            // 
            // Hämta_VäljMedlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 429);
            this.Controls.Add(this.btn_Forsätt);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_väljMedlem);
            this.Name = "Hämta_VäljMedlem";
            this.Text = "Hämta_VäljMedlem";
            this.Load += new System.EventHandler(this.Hämta_VäljMedlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_väljMedlem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Tillbaka;
        private System.Windows.Forms.Button btn_Forsätt;
    }
}