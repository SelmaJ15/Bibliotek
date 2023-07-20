
namespace BibliotekPL
{
    partial class ÅterlämnaBok
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
            this.lbl_Återlämnade = new System.Windows.Forms.Label();
            this.lbl_EjÅterlämnade = new System.Windows.Forms.Label();
            this.listBox_Återlämnade = new System.Windows.Forms.ListBox();
            this.listBox_Bokningar = new System.Windows.Forms.ListBox();
            this.btn_välj = new System.Windows.Forms.Button();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.lbl_ExpeditID = new System.Windows.Forms.Label();
            this.lbl_MedlemID = new System.Windows.Forms.Label();
            this.label_eID = new System.Windows.Forms.Label();
            this.label_mID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Återlämnade
            // 
            this.lbl_Återlämnade.AutoSize = true;
            this.lbl_Återlämnade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Återlämnade.Location = new System.Drawing.Point(142, 102);
            this.lbl_Återlämnade.Name = "lbl_Återlämnade";
            this.lbl_Återlämnade.Size = new System.Drawing.Size(100, 19);
            this.lbl_Återlämnade.TabIndex = 0;
            this.lbl_Återlämnade.Text = "Återlämnade";
            // 
            // lbl_EjÅterlämnade
            // 
            this.lbl_EjÅterlämnade.AutoSize = true;
            this.lbl_EjÅterlämnade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EjÅterlämnade.Location = new System.Drawing.Point(393, 102);
            this.lbl_EjÅterlämnade.Name = "lbl_EjÅterlämnade";
            this.lbl_EjÅterlämnade.Size = new System.Drawing.Size(117, 19);
            this.lbl_EjÅterlämnade.TabIndex = 1;
            this.lbl_EjÅterlämnade.Text = "Ej återlämnade";
            // 
            // listBox_Återlämnade
            // 
            this.listBox_Återlämnade.FormattingEnabled = true;
            this.listBox_Återlämnade.ItemHeight = 20;
            this.listBox_Återlämnade.Location = new System.Drawing.Point(128, 142);
            this.listBox_Återlämnade.Name = "listBox_Återlämnade";
            this.listBox_Återlämnade.Size = new System.Drawing.Size(155, 204);
            this.listBox_Återlämnade.TabIndex = 2;
            // 
            // listBox_Bokningar
            // 
            this.listBox_Bokningar.FormattingEnabled = true;
            this.listBox_Bokningar.ItemHeight = 20;
            this.listBox_Bokningar.Location = new System.Drawing.Point(370, 142);
            this.listBox_Bokningar.Name = "listBox_Bokningar";
            this.listBox_Bokningar.Size = new System.Drawing.Size(158, 204);
            this.listBox_Bokningar.TabIndex = 3;
            // 
            // btn_välj
            // 
            this.btn_välj.Location = new System.Drawing.Point(571, 409);
            this.btn_välj.Name = "btn_välj";
            this.btn_välj.Size = new System.Drawing.Size(94, 29);
            this.btn_välj.TabIndex = 4;
            this.btn_välj.Text = "Välj";
            this.btn_välj.UseVisualStyleBackColor = true;
            this.btn_välj.Click += new System.EventHandler(this.btn_välj_Click);
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(13, 408);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 5;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // lbl_ExpeditID
            // 
            this.lbl_ExpeditID.AutoSize = true;
            this.lbl_ExpeditID.Location = new System.Drawing.Point(25, 33);
            this.lbl_ExpeditID.Name = "lbl_ExpeditID";
            this.lbl_ExpeditID.Size = new System.Drawing.Size(77, 20);
            this.lbl_ExpeditID.TabIndex = 6;
            this.lbl_ExpeditID.Text = "ExpeditID:";
            // 
            // lbl_MedlemID
            // 
            this.lbl_MedlemID.AutoSize = true;
            this.lbl_MedlemID.Location = new System.Drawing.Point(529, 33);
            this.lbl_MedlemID.Name = "lbl_MedlemID";
            this.lbl_MedlemID.Size = new System.Drawing.Size(82, 20);
            this.lbl_MedlemID.TabIndex = 7;
            this.lbl_MedlemID.Text = "MedlemID:";
            // 
            // label_eID
            // 
            this.label_eID.AutoSize = true;
            this.label_eID.Location = new System.Drawing.Point(100, 33);
            this.label_eID.Name = "label_eID";
            this.label_eID.Size = new System.Drawing.Size(24, 20);
            this.label_eID.TabIndex = 8;
            this.label_eID.Text = "ID";
            // 
            // label_mID
            // 
            this.label_mID.AutoSize = true;
            this.label_mID.Location = new System.Drawing.Point(617, 33);
            this.label_mID.Name = "label_mID";
            this.label_mID.Size = new System.Drawing.Size(24, 20);
            this.label_mID.TabIndex = 9;
            this.label_mID.Text = "ID";
            // 
            // ÅterlämnaBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.label_mID);
            this.Controls.Add(this.label_eID);
            this.Controls.Add(this.lbl_MedlemID);
            this.Controls.Add(this.lbl_ExpeditID);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.btn_välj);
            this.Controls.Add(this.listBox_Bokningar);
            this.Controls.Add(this.listBox_Återlämnade);
            this.Controls.Add(this.lbl_EjÅterlämnade);
            this.Controls.Add(this.lbl_Återlämnade);
            this.Name = "ÅterlämnaBok";
            this.Text = "ÅterlämnaBok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Återlämnade;
        private System.Windows.Forms.Label lbl_EjÅterlämnade;
        private System.Windows.Forms.ListBox listBox_Återlämnade;
        private System.Windows.Forms.ListBox listBox_Bokningar;
        private System.Windows.Forms.Button btn_välj;
        private System.Windows.Forms.Button btn_Tillbaka;
        private System.Windows.Forms.Label lbl_ExpeditID;
        private System.Windows.Forms.Label lbl_MedlemID;
        private System.Windows.Forms.Label label_eID;
        private System.Windows.Forms.Label label_mID;
    }
}