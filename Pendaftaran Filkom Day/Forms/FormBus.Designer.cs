namespace Tugas_Project_akhir
{
    partial class FormBus
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtbus = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.btncari = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbaru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIM";
            // 
            // txtnim
            // 
            this.txtnim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtnim.Location = new System.Drawing.Point(177, 71);
            this.txtnim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(295, 26);
            this.txtnim.TabIndex = 4;
            // 
            // txtbus
            // 
            this.txtbus.Location = new System.Drawing.Point(177, 169);
            this.txtbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbus.Name = "txtbus";
            this.txtbus.Size = new System.Drawing.Size(295, 26);
            this.txtbus.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(177, 119);
            this.txtnama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(295, 26);
            this.txtnama.TabIndex = 6;
            // 
            // btncari
            // 
            this.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncari.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncari.Location = new System.Drawing.Point(502, 53);
            this.btncari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(208, 60);
            this.btncari.TabIndex = 7;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(1167, 236);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(208, 60);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 699);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 351);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(25, 216);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(147, 29);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "Keterangan";
            // 
            // txtket
            // 
            this.txtket.Location = new System.Drawing.Point(177, 220);
            this.txtket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtket.Name = "txtket";
            this.txtket.Size = new System.Drawing.Size(295, 26);
            this.txtket.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA BUS FILKOM DAY ";
            // 
            // btnbaru
            // 
            this.btnbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaru.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaru.Location = new System.Drawing.Point(916, 236);
            this.btnbaru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbaru.Name = "btnbaru";
            this.btnbaru.Size = new System.Drawing.Size(208, 60);
            this.btnbaru.TabIndex = 14;
            this.btnbaru.Text = "Baru";
            this.btnbaru.UseVisualStyleBackColor = true;
            this.btnbaru.Click += new System.EventHandler(this.btnbaru_Click);
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1415, 1050);
            this.Controls.Add(this.btnbaru);
            this.Controls.Add(this.txtket);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtbus);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBus";
            this.Text = "FormBus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBus_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtbus;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbaru;
    }
}

