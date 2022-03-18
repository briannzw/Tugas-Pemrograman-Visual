/*
 * Created by SharpDevelop.
 * User: BrianzW
 * Date: 3/18/2022
 * Time: 22:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kalkulator_Sederhana
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_angka1 = new System.Windows.Forms.Label();
			this.lbl_angka2 = new System.Windows.Forms.Label();
			this.tb_angka1 = new System.Windows.Forms.TextBox();
			this.tb_angka2 = new System.Windows.Forms.TextBox();
			this.lbl_txthasil = new System.Windows.Forms.Label();
			this.lbl_hasil = new System.Windows.Forms.Label();
			this.btn_tambah = new System.Windows.Forms.Button();
			this.btn_kurang = new System.Windows.Forms.Button();
			this.btn_kali = new System.Windows.Forms.Button();
			this.btn_bagi = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_angka1
			// 
			this.lbl_angka1.Location = new System.Drawing.Point(12, 9);
			this.lbl_angka1.Name = "lbl_angka1";
			this.lbl_angka1.Size = new System.Drawing.Size(100, 23);
			this.lbl_angka1.TabIndex = 0;
			this.lbl_angka1.Text = "Angka 1";
			// 
			// lbl_angka2
			// 
			this.lbl_angka2.Location = new System.Drawing.Point(12, 41);
			this.lbl_angka2.Name = "lbl_angka2";
			this.lbl_angka2.Size = new System.Drawing.Size(100, 23);
			this.lbl_angka2.TabIndex = 1;
			this.lbl_angka2.Text = "Angka 2";
			// 
			// tb_angka1
			// 
			this.tb_angka1.Location = new System.Drawing.Point(84, 6);
			this.tb_angka1.Name = "tb_angka1";
			this.tb_angka1.Size = new System.Drawing.Size(100, 22);
			this.tb_angka1.TabIndex = 2;
			// 
			// tb_angka2
			// 
			this.tb_angka2.Location = new System.Drawing.Point(84, 38);
			this.tb_angka2.Name = "tb_angka2";
			this.tb_angka2.Size = new System.Drawing.Size(100, 22);
			this.tb_angka2.TabIndex = 3;
			// 
			// lbl_txthasil
			// 
			this.lbl_txthasil.Location = new System.Drawing.Point(13, 68);
			this.lbl_txthasil.Name = "lbl_txthasil";
			this.lbl_txthasil.Size = new System.Drawing.Size(100, 23);
			this.lbl_txthasil.TabIndex = 4;
			this.lbl_txthasil.Text = "Hasil";
			// 
			// lbl_hasil
			// 
			this.lbl_hasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_hasil.Location = new System.Drawing.Point(84, 68);
			this.lbl_hasil.Name = "lbl_hasil";
			this.lbl_hasil.Size = new System.Drawing.Size(100, 23);
			this.lbl_hasil.TabIndex = 5;
			this.lbl_hasil.Text = "0";
			// 
			// btn_tambah
			// 
			this.btn_tambah.Location = new System.Drawing.Point(12, 106);
			this.btn_tambah.Name = "btn_tambah";
			this.btn_tambah.Size = new System.Drawing.Size(75, 23);
			this.btn_tambah.TabIndex = 6;
			this.btn_tambah.Text = "+";
			this.btn_tambah.UseVisualStyleBackColor = true;
			this.btn_tambah.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn_kurang
			// 
			this.btn_kurang.Location = new System.Drawing.Point(93, 106);
			this.btn_kurang.Name = "btn_kurang";
			this.btn_kurang.Size = new System.Drawing.Size(75, 23);
			this.btn_kurang.TabIndex = 7;
			this.btn_kurang.Text = "-";
			this.btn_kurang.UseVisualStyleBackColor = true;
			this.btn_kurang.Click += new System.EventHandler(this.Btn_kurangClick);
			// 
			// btn_kali
			// 
			this.btn_kali.Location = new System.Drawing.Point(12, 135);
			this.btn_kali.Name = "btn_kali";
			this.btn_kali.Size = new System.Drawing.Size(75, 23);
			this.btn_kali.TabIndex = 8;
			this.btn_kali.Text = "*";
			this.btn_kali.UseVisualStyleBackColor = true;
			this.btn_kali.Click += new System.EventHandler(this.Btn_kaliClick);
			// 
			// btn_bagi
			// 
			this.btn_bagi.Location = new System.Drawing.Point(93, 135);
			this.btn_bagi.Name = "btn_bagi";
			this.btn_bagi.Size = new System.Drawing.Size(75, 23);
			this.btn_bagi.TabIndex = 9;
			this.btn_bagi.Text = "/";
			this.btn_bagi.UseVisualStyleBackColor = true;
			this.btn_bagi.Click += new System.EventHandler(this.Btn_bagiClick);
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(175, 106);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(75, 52);
			this.btn_reset.TabIndex = 10;
			this.btn_reset.Text = "C";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.Btn_resetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_bagi);
			this.Controls.Add(this.btn_kali);
			this.Controls.Add(this.btn_kurang);
			this.Controls.Add(this.btn_tambah);
			this.Controls.Add(this.lbl_hasil);
			this.Controls.Add(this.lbl_txthasil);
			this.Controls.Add(this.tb_angka2);
			this.Controls.Add(this.tb_angka1);
			this.Controls.Add(this.lbl_angka2);
			this.Controls.Add(this.lbl_angka1);
			this.Name = "MainForm";
			this.Text = "Kalkulator Sederhana";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Button btn_bagi;
		private System.Windows.Forms.Button btn_kali;
		private System.Windows.Forms.Button btn_kurang;
		private System.Windows.Forms.Button btn_tambah;
		private System.Windows.Forms.Label lbl_hasil;
		private System.Windows.Forms.Label lbl_txthasil;
		private System.Windows.Forms.TextBox tb_angka2;
		private System.Windows.Forms.TextBox tb_angka1;
		private System.Windows.Forms.Label lbl_angka2;
		private System.Windows.Forms.Label lbl_angka1;
	}
}
