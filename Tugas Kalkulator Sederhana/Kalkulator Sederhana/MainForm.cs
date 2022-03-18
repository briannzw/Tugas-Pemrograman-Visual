/*
 * Created by SharpDevelop.
 * User: BrianzW
 * Date: 3/18/2022
 * Time: 22:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		bool check_input(){
			if(string.IsNullOrEmpty(tb_angka1.Text) || string.IsNullOrEmpty(tb_angka2.Text)){
				MessageBox.Show("Angka 1 dan angka 2 tidak boleh kosong");
				return false;
			}
			return true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(check_input()){
				int angka1, angka2, hasil;
				angka1 = int.Parse(tb_angka1.Text);
				angka2 = int.Parse(tb_angka2.Text);
				hasil = angka1 + angka2;
				lbl_hasil.Text = hasil.ToString();
			}
		}
		
		void Btn_kurangClick(object sender, EventArgs e)
		{
			if(check_input()){
				int angka1, angka2, hasil;
				angka1 = int.Parse(tb_angka1.Text);
				angka2 = int.Parse(tb_angka2.Text);
				hasil = angka1 - angka2;
				lbl_hasil.Text = hasil.ToString();
			}
		}
		
		
		
		void Btn_kaliClick(object sender, EventArgs e)
		{
			if(check_input()){
				int angka1, angka2, hasil;
				angka1 = int.Parse(tb_angka1.Text);
				angka2 = int.Parse(tb_angka2.Text);
				hasil = angka1 * angka2;
				lbl_hasil.Text = hasil.ToString();
			}
		}
		
		void Btn_bagiClick(object sender, EventArgs e)
		{
			if(check_input()){
				int angka1, angka2;
				double hasil;
				angka1 = int.Parse(tb_angka1.Text);
				angka2 = int.Parse(tb_angka2.Text);
				hasil = (double)angka1 / angka2;
				lbl_hasil.Text = hasil.ToString();
			}
		}
		
		void Btn_resetClick(object sender, EventArgs e)
		{
			tb_angka1.Clear();
			tb_angka2.Clear();
			lbl_hasil.Text = "";
		}
	}
}
