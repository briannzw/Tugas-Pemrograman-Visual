/*
 * Created by SharpDevelop.
 * User: Brian Wijaya
 * Date: 3/2/2022
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Materi_Pertemuan_4
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
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nama : " + textBox1.Text + "\nNIM : " + textBox2.Text + "\nKelas : " + textBox3.Text + "\nMata Kuliah : " + textBox4.Text, "Informasi");
		}
	}
}
