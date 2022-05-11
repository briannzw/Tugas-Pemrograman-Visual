namespace Tugas_Program_Kasir___Pertemuan_7
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_jual = new System.Windows.Forms.TextBox();
            this.tb_beli = new System.Windows.Forms.TextBox();
            this.tb_jumlah = new System.Windows.Forms.TextBox();
            this.tb_satuan = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_cari_kode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB : Kasir . Table : TBL_BARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satuan";
            // 
            // tb_kode
            // 
            this.tb_kode.Location = new System.Drawing.Point(113, 9);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(253, 27);
            this.tb_kode.TabIndex = 1;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(113, 42);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(675, 27);
            this.tb_nama.TabIndex = 2;
            // 
            // tb_jual
            // 
            this.tb_jual.Location = new System.Drawing.Point(113, 75);
            this.tb_jual.Name = "tb_jual";
            this.tb_jual.Size = new System.Drawing.Size(253, 27);
            this.tb_jual.TabIndex = 3;
            this.tb_jual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jual_KeyPress);
            // 
            // tb_beli
            // 
            this.tb_beli.Location = new System.Drawing.Point(113, 108);
            this.tb_beli.Name = "tb_beli";
            this.tb_beli.Size = new System.Drawing.Size(253, 27);
            this.tb_beli.TabIndex = 4;
            this.tb_beli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_beli_KeyPress);
            // 
            // tb_jumlah
            // 
            this.tb_jumlah.Location = new System.Drawing.Point(113, 141);
            this.tb_jumlah.Name = "tb_jumlah";
            this.tb_jumlah.Size = new System.Drawing.Size(253, 27);
            this.tb_jumlah.TabIndex = 5;
            this.tb_jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jumlah_KeyPress);
            // 
            // tb_satuan
            // 
            this.tb_satuan.Location = new System.Drawing.Point(113, 174);
            this.tb_satuan.Name = "tb_satuan";
            this.tb_satuan.Size = new System.Drawing.Size(253, 27);
            this.tb_satuan.TabIndex = 6;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(434, 102);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(354, 29);
            this.btn_simpan.TabIndex = 7;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(434, 137);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(354, 29);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(434, 174);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(354, 29);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_cari_kode);
            this.groupBox1.Location = new System.Drawing.Point(434, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Kode Barang";
            // 
            // tb_cari_kode
            // 
            this.tb_cari_kode.Location = new System.Drawing.Point(6, 26);
            this.tb_cari_kode.Name = "tb_cari_kode";
            this.tb_cari_kode.Size = new System.Drawing.Size(340, 27);
            this.tb_cari_kode.TabIndex = 0;
            this.tb_cari_kode.TextChanged += new System.EventHandler(this.tb_cari_kode_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.tb_satuan);
            this.Controls.Add(this.tb_jumlah);
            this.Controls.Add(this.tb_beli);
            this.Controls.Add(this.tb_jual);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_kode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Program Kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_kode;
        private TextBox tb_nama;
        private TextBox tb_jual;
        private TextBox tb_beli;
        private TextBox tb_jumlah;
        private TextBox tb_satuan;
        private Button btn_simpan;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox1;
        private TextBox tb_cari_kode;
    }
}