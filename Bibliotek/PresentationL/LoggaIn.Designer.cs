
namespace PresentationL
{
    partial class LoggaIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Användarnamn = new System.Windows.Forms.TextBox();
            this.txtBox_Lösenord = new System.Windows.Forms.TextBox();
            this.btn_LoggaIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen till Borås Bibliotek!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Användarnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lösenord:";
            // 
            // txtBox_Användarnamn
            // 
            this.txtBox_Användarnamn.Location = new System.Drawing.Point(262, 158);
            this.txtBox_Användarnamn.Name = "txtBox_Användarnamn";
            this.txtBox_Användarnamn.Size = new System.Drawing.Size(173, 27);
            this.txtBox_Användarnamn.TabIndex = 3;
            // 
            // txtBox_Lösenord
            // 
            this.txtBox_Lösenord.Location = new System.Drawing.Point(262, 238);
            this.txtBox_Lösenord.Name = "txtBox_Lösenord";
            this.txtBox_Lösenord.Size = new System.Drawing.Size(173, 27);
            this.txtBox_Lösenord.TabIndex = 4;
            // 
            // btn_LoggaIn
            // 
            this.btn_LoggaIn.Location = new System.Drawing.Point(285, 326);
            this.btn_LoggaIn.Name = "btn_LoggaIn";
            this.btn_LoggaIn.Size = new System.Drawing.Size(111, 50);
            this.btn_LoggaIn.TabIndex = 5;
            this.btn_LoggaIn.Text = "Logga in";
            this.btn_LoggaIn.UseVisualStyleBackColor = true;
            this.btn_LoggaIn.Click += new System.EventHandler(this.btn_LoggaIn_Click);
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 419);
            this.Controls.Add(this.btn_LoggaIn);
            this.Controls.Add(this.txtBox_Lösenord);
            this.Controls.Add(this.txtBox_Användarnamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoggaIn";
            this.Text = "LoggaIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Användarnamn;
        private System.Windows.Forms.TextBox txtBox_Lösenord;
        private System.Windows.Forms.Button btn_LoggaIn;
    }
}

