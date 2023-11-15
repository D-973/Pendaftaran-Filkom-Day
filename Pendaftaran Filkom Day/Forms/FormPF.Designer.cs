namespace Pendaftaran_Filkom_Day.Forms
{
    partial class FormPF
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.CBNote = new System.Windows.Forms.ComboBox();
            this.CBMakanan = new System.Windows.Forms.ComboBox();
            this.CBSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPenanggung = new System.Windows.Forms.TextBox();
            this.TxtBiaya = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtNIM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CBTingkat = new System.Windows.Forms.ComboBox();
            this.CBProdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(618, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 39);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CBNote
            // 
            this.CBNote.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNote.FormattingEnabled = true;
            this.CBNote.Items.AddRange(new object[] {
            "Lunas",
            "Belum lunas"});
            this.CBNote.Location = new System.Drawing.Point(1052, 232);
            this.CBNote.Name = "CBNote";
            this.CBNote.Size = new System.Drawing.Size(290, 39);
            this.CBNote.TabIndex = 48;
            // 
            // CBMakanan
            // 
            this.CBMakanan.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMakanan.FormattingEnabled = true;
            this.CBMakanan.Items.AddRange(new object[] {
            "Ayam",
            "Ikan",
            "Vegetarian"});
            this.CBMakanan.Location = new System.Drawing.Point(1052, 76);
            this.CBMakanan.Name = "CBMakanan";
            this.CBMakanan.Size = new System.Drawing.Size(290, 39);
            this.CBMakanan.TabIndex = 47;
            // 
            // CBSize
            // 
            this.CBSize.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSize.FormattingEnabled = true;
            this.CBSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL",
            "XXXXL"});
            this.CBSize.Location = new System.Drawing.Point(296, 445);
            this.CBSize.Name = "CBSize";
            this.CBSize.Size = new System.Drawing.Size(305, 39);
            this.CBSize.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 31);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tingkat";
            // 
            // TxtPenanggung
            // 
            this.TxtPenanggung.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPenanggung.Location = new System.Drawing.Point(1052, 303);
            this.TxtPenanggung.Name = "TxtPenanggung";
            this.TxtPenanggung.Size = new System.Drawing.Size(290, 39);
            this.TxtPenanggung.TabIndex = 39;
            // 
            // TxtBiaya
            // 
            this.TxtBiaya.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBiaya.Location = new System.Drawing.Point(1052, 161);
            this.TxtBiaya.Name = "TxtBiaya";
            this.TxtBiaya.Size = new System.Drawing.Size(290, 39);
            this.TxtBiaya.TabIndex = 38;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(296, 232);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(306, 39);
            this.TxtFirstName.TabIndex = 37;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(296, 161);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(306, 39);
            this.TxtLastName.TabIndex = 36;
            // 
            // TxtNIM
            // 
            this.TxtNIM.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNIM.Location = new System.Drawing.Point(296, 89);
            this.TxtNIM.Name = "TxtNIM";
            this.TxtNIM.Size = new System.Drawing.Size(306, 39);
            this.TxtNIM.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(799, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 31);
            this.label10.TabIndex = 34;
            this.label10.Text = "Penanggung Jawab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(801, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 31);
            this.label9.TabIndex = 33;
            this.label9.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(799, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Biaya";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ukuran Baju";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(799, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Makanan";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(40, 303);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 31);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nama Depan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nama Belakang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "NIM";
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(1052, 374);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(290, 39);
            this.TxtDate.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(799, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Date";
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(158, 576);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(205, 76);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1100, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 76);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CBTingkat
            // 
            this.CBTingkat.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTingkat.FormattingEnabled = true;
            this.CBTingkat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "4+"});
            this.CBTingkat.Location = new System.Drawing.Point(296, 374);
            this.CBTingkat.Name = "CBTingkat";
            this.CBTingkat.Size = new System.Drawing.Size(305, 39);
            this.CBTingkat.TabIndex = 54;
            // 
            // CBProdi
            // 
            this.CBProdi.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProdi.FormattingEnabled = true;
            this.CBProdi.Items.AddRange(new object[] {
            "SI",
            "TI"});
            this.CBProdi.Location = new System.Drawing.Point(295, 303);
            this.CBProdi.Name = "CBProdi";
            this.CBProdi.Size = new System.Drawing.Size(306, 39);
            this.CBProdi.TabIndex = 42;
            // 
            // FormPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1431, 721);
            this.Controls.Add(this.CBTingkat);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.CBNote);
            this.Controls.Add(this.CBMakanan);
            this.Controls.Add(this.CBSize);
            this.Controls.Add(this.CBProdi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPenanggung);
            this.Controls.Add(this.TxtBiaya);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtNIM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "FormPF";
            this.Text = "Form Pendaftaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox CBNote;
        private System.Windows.Forms.ComboBox CBMakanan;
        private System.Windows.Forms.ComboBox CBSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPenanggung;
        private System.Windows.Forms.TextBox TxtBiaya;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtNIM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CBTingkat;
        private System.Windows.Forms.ComboBox CBProdi;
    }
}