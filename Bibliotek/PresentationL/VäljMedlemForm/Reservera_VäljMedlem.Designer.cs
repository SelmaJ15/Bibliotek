
namespace BibliotekPL.VäljMedlemForm
{
    partial class Reservera_VäljMedlem
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
            this.dataGridView1_Medlemar = new System.Windows.Forms.DataGridView();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.textBox_Återlämningstid = new System.Windows.Forms.TextBox();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.btn_Fortsätt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Medlemar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_VäljMedlem
            // 
            this.lbl_VäljMedlem.AutoSize = true;
            this.lbl_VäljMedlem.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_VäljMedlem.Location = new System.Drawing.Point(297, 69);
            this.lbl_VäljMedlem.Name = "lbl_VäljMedlem";
            this.lbl_VäljMedlem.Size = new System.Drawing.Size(171, 34);
            this.lbl_VäljMedlem.TabIndex = 0;
            this.lbl_VäljMedlem.Text = "Välj medlem";
            // 
            // dataGridView1_Medlemar
            // 
            this.dataGridView1_Medlemar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Medlemar.Location = new System.Drawing.Point(124, 140);
            this.dataGridView1_Medlemar.Name = "dataGridView1_Medlemar";
            this.dataGridView1_Medlemar.RowHeadersWidth = 51;
            this.dataGridView1_Medlemar.RowTemplate.Height = 29;
            this.dataGridView1_Medlemar.Size = new System.Drawing.Size(541, 188);
            this.dataGridView1_Medlemar.TabIndex = 1;
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datum.Location = new System.Drawing.Point(232, 355);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(361, 20);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "Vilket datum ska böcker återlämnas? (åååå-mm-dd)";
            // 
            // textBox_Återlämningstid
            // 
            this.textBox_Återlämningstid.Location = new System.Drawing.Point(257, 389);
            this.textBox_Återlämningstid.Name = "textBox_Återlämningstid";
            this.textBox_Återlämningstid.Size = new System.Drawing.Size(303, 27);
            this.textBox_Återlämningstid.TabIndex = 3;
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(12, 448);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 4;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // btn_Fortsätt
            // 
            this.btn_Fortsätt.Location = new System.Drawing.Point(694, 448);
            this.btn_Fortsätt.Name = "btn_Fortsätt";
            this.btn_Fortsätt.Size = new System.Drawing.Size(94, 29);
            this.btn_Fortsätt.TabIndex = 5;
            this.btn_Fortsätt.Text = "Fortsätt";
            this.btn_Fortsätt.UseVisualStyleBackColor = true;
            // 
            // Reservera_VäljMedlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btn_Fortsätt);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.textBox_Återlämningstid);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.dataGridView1_Medlemar);
            this.Controls.Add(this.lbl_VäljMedlem);
            this.Name = "Reservera_VäljMedlem";
            this.Text = "Reservera_VäljMedlem";
            this.Load += new System.EventHandler(this.Reservera_VäljMedlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Medlemar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VäljMedlem;
        private System.Windows.Forms.DataGridView dataGridView1_Medlemar;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.TextBox textBox_Återlämningstid;
        private System.Windows.Forms.Button btn_Tillbaka;
        private System.Windows.Forms.Button btn_Fortsätt;
    }
}