
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnEncryptionDecryption = new DevExpress.XtraEditors.SimpleButton();
            this.txtDecryption = new DevExpress.XtraEditors.TextEdit();
            this.richEncryption = new System.Windows.Forms.RichTextBox();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecryption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel2.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.txtData);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.richEncryption);
            this.tablePanel1.Controls.Add(this.txtDecryption);
            this.tablePanel1.Location = new System.Drawing.Point(3, 116);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel2.SetRow(this.tablePanel1, 1);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(794, 219);
            this.tablePanel1.TabIndex = 3;
            // 
            // btnEncryptionDecryption
            // 
            this.tablePanel3.SetColumn(this.btnEncryptionDecryption, 2);
            this.btnEncryptionDecryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncryptionDecryption.Location = new System.Drawing.Point(553, 3);
            this.btnEncryptionDecryption.Name = "btnEncryptionDecryption";
            this.tablePanel3.SetRow(this.btnEncryptionDecryption, 0);
            this.btnEncryptionDecryption.Size = new System.Drawing.Size(132, 20);
            this.btnEncryptionDecryption.TabIndex = 3;
            this.btnEncryptionDecryption.Text = "Şifrele | Çözümle";
            this.btnEncryptionDecryption.Click += new System.EventHandler(this.btnEncryptionDecryption_Click);
            // 
            // txtDecryption
            // 
            this.tablePanel1.SetColumn(this.txtDecryption, 1);
            this.txtDecryption.Location = new System.Drawing.Point(103, 136);
            this.txtDecryption.Name = "txtDecryption";
            this.txtDecryption.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDecryption.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.txtDecryption, 2);
            this.txtDecryption.Size = new System.Drawing.Size(688, 24);
            this.txtDecryption.TabIndex = 6;
            // 
            // richEncryption
            // 
            this.tablePanel1.SetColumn(this.richEncryption, 1);
            this.richEncryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEncryption.Location = new System.Drawing.Point(103, 33);
            this.richEncryption.Name = "richEncryption";
            this.tablePanel1.SetRow(this.richEncryption, 1);
            this.richEncryption.Size = new System.Drawing.Size(688, 97);
            this.richEncryption.TabIndex = 7;
            this.richEncryption.Text = "";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.tablePanel1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel2.Size = new System.Drawing.Size(800, 450);
            this.tablePanel2.TabIndex = 4;
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel3.Controls.Add(this.button1);
            this.tablePanel3.Controls.Add(this.btnEncryptionDecryption);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(103, 192);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 4);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(688, 24);
            this.tablePanel3.TabIndex = 8;
            // 
            // txtData
            // 
            this.tablePanel1.SetColumn(this.txtData, 1);
            this.txtData.Location = new System.Drawing.Point(103, 4);
            this.txtData.Name = "txtData";
            this.tablePanel1.SetRow(this.txtData, 0);
            this.txtData.Size = new System.Drawing.Size(688, 21);
            this.txtData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifrelenecek Veri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifrelenen Veri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Location = new System.Drawing.Point(3, 141);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Çözümlenen Veri:";
            // 
            // button1
            // 
            this.tablePanel3.SetColumn(this.button1, 0);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.tablePanel3.SetRow(this.button1, 0);
            this.button1.Size = new System.Drawing.Size(269, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablePanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecryption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnEncryptionDecryption;
        private DevExpress.XtraEditors.TextEdit txtDecryption;
        private System.Windows.Forms.RichTextBox richEncryption;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button button1;
    }
}

