
namespace BibliotekPL
{
    partial class Meny
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
            this.lbl_Meny = new System.Windows.Forms.Label();
            this.btn_Reservera = new System.Windows.Forms.Button();
            this.btn_Uthämtning = new System.Windows.Forms.Button();
            this.btn_Återlämning = new System.Windows.Forms.Button();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Meny
            // 
            this.lbl_Meny.AutoSize = true;
            this.lbl_Meny.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Meny.Location = new System.Drawing.Point(215, 35);
            this.lbl_Meny.Name = "lbl_Meny";
            this.lbl_Meny.Size = new System.Drawing.Size(105, 43);
            this.lbl_Meny.TabIndex = 0;
            this.lbl_Meny.Text = "Meny";
            // 
            // btn_Reservera
            // 
            this.btn_Reservera.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reservera.Location = new System.Drawing.Point(195, 119);
            this.btn_Reservera.Name = "btn_Reservera";
            this.btn_Reservera.Size = new System.Drawing.Size(151, 63);
            this.btn_Reservera.TabIndex = 1;
            this.btn_Reservera.Text = "Reservera bok";
            this.btn_Reservera.UseVisualStyleBackColor = true;
            this.btn_Reservera.Click += new System.EventHandler(this.btn_Reservera_Click);
            // 
            // btn_Uthämtning
            // 
            this.btn_Uthämtning.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Uthämtning.Location = new System.Drawing.Point(195, 227);
            this.btn_Uthämtning.Name = "btn_Uthämtning";
            this.btn_Uthämtning.Size = new System.Drawing.Size(151, 64);
            this.btn_Uthämtning.TabIndex = 2;
            this.btn_Uthämtning.Text = "Uthämtning av böcker";
            this.btn_Uthämtning.UseVisualStyleBackColor = true;
            this.btn_Uthämtning.Click += new System.EventHandler(this.btn_Uthämtning_Click);
            // 
            // btn_Återlämning
            // 
            this.btn_Återlämning.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Återlämning.Location = new System.Drawing.Point(195, 337);
            this.btn_Återlämning.Name = "btn_Återlämning";
            this.btn_Återlämning.Size = new System.Drawing.Size(151, 64);
            this.btn_Återlämning.TabIndex = 3;
            this.btn_Återlämning.Text = "Återlämning av böcker";
            this.btn_Återlämning.UseVisualStyleBackColor = true;
            this.btn_Återlämning.Click += new System.EventHandler(this.btn_Återlämning_Click);
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(12, 416);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 4;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 457);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.btn_Återlämning);
            this.Controls.Add(this.btn_Uthämtning);
            this.Controls.Add(this.btn_Reservera);
            this.Controls.Add(this.lbl_Meny);
            this.Name = "Meny";
            this.Text = "Meny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Meny;
        private System.Windows.Forms.Button btn_Reservera;
        private System.Windows.Forms.Button btn_Uthämtning;
        private System.Windows.Forms.Button btn_Återlämning;
        private System.Windows.Forms.Button btn_Tillbaka;
    }
}