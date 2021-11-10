
namespace EncryptionDecryption
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.richEncryption = new System.Windows.Forms.RichTextBox();
            this.txtDecryption = new System.Windows.Forms.TextBox();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Çözümlenen Veri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifrelenen Veri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifrelenecek Veri:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtData.Location = new System.Drawing.Point(236, 86);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(438, 26);
            this.txtData.TabIndex = 4;
            // 
            // btnEncryption
            // 
            this.btnEncryption.Location = new System.Drawing.Point(321, 301);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(165, 20);
            this.btnEncryption.TabIndex = 4;
            this.btnEncryption.Text = "Şifrele";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // richEncryption
            // 
            this.richEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richEncryption.Location = new System.Drawing.Point(236, 129);
            this.richEncryption.Name = "richEncryption";
            this.richEncryption.Size = new System.Drawing.Size(438, 105);
            this.richEncryption.TabIndex = 7;
            this.richEncryption.Text = "";
            // 
            // txtDecryption
            // 
            this.txtDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDecryption.Location = new System.Drawing.Point(236, 252);
            this.txtDecryption.Name = "txtDecryption";
            this.txtDecryption.Size = new System.Drawing.Size(438, 26);
            this.txtDecryption.TabIndex = 12;
            // 
            // btnDecryption
            // 
            this.btnDecryption.Location = new System.Drawing.Point(509, 301);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(165, 20);
            this.btnDecryption.TabIndex = 13;
            this.btnDecryption.Text = "Çözümle";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.txtDecryption);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.richEncryption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richEncryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.TextBox txtDecryption;
        private System.Windows.Forms.Button btnDecryption;
    }
}

