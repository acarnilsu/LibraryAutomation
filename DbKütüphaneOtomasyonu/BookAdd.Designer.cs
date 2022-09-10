namespace DbKütüphaneOtomasyonu
{
    partial class BookAdd
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtBookStock = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tblWriterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkütüphaneOtomasyonuDataSet = new DbKütüphaneOtomasyonu.DbkütüphaneOtomasyonuDataSet();
            this.tblWriterTableAdapter = new DbKütüphaneOtomasyonu.DbkütüphaneOtomasyonuDataSetTableAdapters.TblWriterTableAdapter();
            this.cmbWriter = new System.Windows.Forms.ComboBox();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblWriterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkütüphaneOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı :";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(185, 104);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(191, 27);
            this.txtBookName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(162, 380);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayın Evi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sayfa Sayısı :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stok Adedi :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalPage.Location = new System.Drawing.Point(185, 264);
            this.txtTotalPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(191, 27);
            this.txtTotalPage.TabIndex = 10;
            // 
            // txtBookStock
            // 
            this.txtBookStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookStock.Location = new System.Drawing.Point(185, 323);
            this.txtBookStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookStock.Name = "txtBookStock";
            this.txtBookStock.Size = new System.Drawing.Size(191, 27);
            this.txtBookStock.TabIndex = 11;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookID.Location = new System.Drawing.Point(185, 41);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(191, 27);
            this.txtBookID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap ID :";
            // 
            // tblWriterBindingSource
            // 
            this.tblWriterBindingSource.DataMember = "TblWriter";
            this.tblWriterBindingSource.DataSource = this.dbkütüphaneOtomasyonuDataSet;
            // 
            // dbkütüphaneOtomasyonuDataSet
            // 
            this.dbkütüphaneOtomasyonuDataSet.DataSetName = "DbkütüphaneOtomasyonuDataSet";
            this.dbkütüphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWriterTableAdapter
            // 
            this.tblWriterTableAdapter.ClearBeforeFill = true;
            // 
            // cmbWriter
            // 
            this.cmbWriter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbWriter.FormattingEnabled = true;
            this.cmbWriter.Location = new System.Drawing.Point(185, 161);
            this.cmbWriter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWriter.Name = "cmbWriter";
            this.cmbWriter.Size = new System.Drawing.Size(191, 27);
            this.cmbWriter.TabIndex = 14;
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(185, 211);
            this.cmbPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(191, 27);
            this.cmbPublisher.TabIndex = 15;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 458);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.cmbWriter);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBookStock);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookAdd";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.BookAdd_Load);
            this.Leave += new System.EventHandler(this.BookAdd_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.tblWriterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkütüphaneOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.TextBox txtBookStock;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label6;
        private DbkütüphaneOtomasyonuDataSet dbkütüphaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblWriterBindingSource;
        private DbkütüphaneOtomasyonuDataSetTableAdapters.TblWriterTableAdapter tblWriterTableAdapter;
        private System.Windows.Forms.ComboBox cmbWriter;
        private System.Windows.Forms.ComboBox cmbPublisher;
    }
}