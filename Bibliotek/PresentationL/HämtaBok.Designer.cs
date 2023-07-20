
namespace BibliotekPL
{
    partial class HämtaBok
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
            this.lbl_bokningar = new System.Windows.Forms.Label();
            this.listBox_Bokningar = new System.Windows.Forms.ListBox();
            this.btn_Välj = new System.Windows.Forms.Button();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.lbl_ExpeditID = new System.Windows.Forms.Label();
            this.label_eID = new System.Windows.Forms.Label();
            this.lbl_MedlemID = new System.Windows.Forms.Label();
            this.label_mID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bokningar
            // 
            this.lbl_bokningar.AutoSize = true;
            this.lbl_bokningar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bokningar.Location = new System.Drawing.Point(235, 91);
            this.lbl_bokningar.Name = "lbl_bokningar";
            this.lbl_bokningar.Size = new System.Drawing.Size(88, 22);
            this.lbl_bokningar.TabIndex = 0;
            this.lbl_bokningar.Text = "Bokningar:";
            // 
            // listBox_Bokningar
            // 
            this.listBox_Bokningar.FormattingEnabled = true;
            this.listBox_Bokningar.ItemHeight = 20;
            this.listBox_Bokningar.Location = new System.Drawing.Point(188, 125);
            this.listBox_Bokningar.Name = "listBox_Bokningar";
            this.listBox_Bokningar.Size = new System.Drawing.Size(172, 224);
            this.listBox_Bokningar.TabIndex = 1;
            // 
            // btn_Välj
            // 
            this.btn_Välj.Location = new System.Drawing.Point(455, 400);
            this.btn_Välj.Name = "btn_Välj";
            this.btn_Välj.Size = new System.Drawing.Size(94, 29);
            this.btn_Välj.TabIndex = 2;
            this.btn_Välj.Text = "Välj";
            this.btn_Välj.UseVisualStyleBackColor = true;
            this.btn_Välj.Click += new System.EventHandler(this.btn_Välj_Click);
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(12, 400);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(94, 29);
            this.btn_Tillbaka.TabIndex = 3;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // lbl_ExpeditID
            // 
            this.lbl_ExpeditID.AutoSize = true;
            this.lbl_ExpeditID.Location = new System.Drawing.Point(23, 22);
            this.lbl_ExpeditID.Name = "lbl_ExpeditID";
            this.lbl_ExpeditID.Size = new System.Drawing.Size(77, 20);
            this.lbl_ExpeditID.TabIndex = 4;
            this.lbl_ExpeditID.Text = "ExpeditID:";
            // 
            // label_eID
            // 
            this.label_eID.AutoSize = true;
            this.label_eID.Location = new System.Drawing.Point(107, 22);
            this.label_eID.Name = "label_eID";
            this.label_eID.Size = new System.Drawing.Size(24, 20);
            this.label_eID.TabIndex = 5;
            this.label_eID.Text = "ID";
            // 
            // lbl_MedlemID
            // 
            this.lbl_MedlemID.AutoSize = true;
            this.lbl_MedlemID.Location = new System.Drawing.Point(419, 22);
            this.lbl_MedlemID.Name = "lbl_MedlemID";
            this.lbl_MedlemID.Size = new System.Drawing.Size(82, 20);
            this.lbl_MedlemID.TabIndex = 6;
            this.lbl_MedlemID.Text = "MedlemID:";
            // 
            // label_mID
            // 
            this.label_mID.AutoSize = true;
            this.label_mID.Location = new System.Drawing.Point(507, 22);
            this.label_mID.Name = "label_mID";
            this.label_mID.Size = new System.Drawing.Size(24, 20);
            this.label_mID.TabIndex = 7;
            this.label_mID.Text = "ID";
            // 
            // HämtaBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 441);
            this.Controls.Add(this.label_mID);
            this.Controls.Add(this.lbl_MedlemID);
            this.Controls.Add(this.label_eID);
            this.Controls.Add(this.lbl_ExpeditID);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.btn_Välj);
            this.Controls.Add(this.listBox_Bokningar);
            this.Controls.Add(this.lbl_bokningar);
            this.Name = "HämtaBok";
            this.Text = "HämtaBok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bokningar;
        private System.Windows.Forms.ListBox listBox_Bokningar;
        private System.Windows.Forms.Button btn_Välj;
        private System.Windows.Forms.Button btn_Tillbaka;
        private System.Windows.Forms.Label lbl_ExpeditID;
        private System.Windows.Forms.Label label_eID;
        private System.Windows.Forms.Label lbl_MedlemID;
        private System.Windows.Forms.Label label_mID;
    }
}