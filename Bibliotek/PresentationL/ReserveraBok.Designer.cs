
namespace BibliotekPL
{
    partial class ReserveraBok
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
            this.label1 = new System.Windows.Forms.Label();
            this.List_TillgängligaBöcker = new System.Windows.Forms.ListBox();
            this.btn_Reservera = new System.Windows.Forms.Button();
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Markera de böcker du vill reservera:";
            // 
            // List_TillgängligaBöcker
            // 
            this.List_TillgängligaBöcker.FormattingEnabled = true;
            this.List_TillgängligaBöcker.ItemHeight = 20;
            this.List_TillgängligaBöcker.Location = new System.Drawing.Point(216, 134);
            this.List_TillgängligaBöcker.Name = "List_TillgängligaBöcker";
            this.List_TillgängligaBöcker.Size = new System.Drawing.Size(229, 284);
            this.List_TillgängligaBöcker.TabIndex = 1;
            // 
            // btn_Reservera
            // 
            this.btn_Reservera.Location = new System.Drawing.Point(279, 460);
            this.btn_Reservera.Name = "btn_Reservera";
            this.btn_Reservera.Size = new System.Drawing.Size(108, 43);
            this.btn_Reservera.TabIndex = 2;
            this.btn_Reservera.Text = "Reservera";
            this.btn_Reservera.UseVisualStyleBackColor = true;
            this.btn_Reservera.Click += new System.EventHandler(this.btn_Reservera_Click);
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Tillbaka.Location = new System.Drawing.Point(13, 13);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(75, 29);
            this.btn_Tillbaka.TabIndex = 3;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // ReserveraBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.btn_Tillbaka);
            this.Controls.Add(this.btn_Reservera);
            this.Controls.Add(this.List_TillgängligaBöcker);
            this.Controls.Add(this.label1);
            this.Name = "ReserveraBok";
            this.Text = "ReserveraBok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox List_TillgängligaBöcker;
        private System.Windows.Forms.Button btn_Reservera;
        private System.Windows.Forms.Button btn_Tillbaka;
    }
}