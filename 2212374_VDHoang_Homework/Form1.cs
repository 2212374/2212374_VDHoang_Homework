using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212374_VDHoang_Homework
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "MSSV";
			label2.Text = "Ho Ten";
			label3.Text = "Dia Chi";
			label4.Text = "Nam Sinh";
			label5.Text = "SDT";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void lbDanhsachChon_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int itemsselect = lbDanhsach.SelectedItems.Count - 1;
			for (int i = itemsselect; i >= 0; i--)
			{
				lbDanhsachChon.Items.Add(lbDanhsach.SelectedItems[i]);
				lbDanhsach.Items.Remove(lbDanhsach.SelectedItems[i]);
			}
		}

		private void pn52_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnRemore_Click(object sender, EventArgs e)
		{
			int i = lbDanhsachChon.SelectedItems.Count - 1;
			while (i >= 0)
			{
				lbDanhsachChon.Items.RemoveAt(lbDanhsachChon.SelectedIndices[i]);
				i--;
			}
		}

		private void rdMen_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdMen.Checked)
			{
				MessageBox.Show("Giới tính bạn là: " + rdMen.Text);
			}
		}

		private void rdGirl_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdGirl.Checked)
			{
				MessageBox.Show("Giới tính bạn là: " + rdGirl.Text);
			}
		}

		private void cboCNN_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show(this.cboCNN.SelectedItem.ToString());
		}

		private void btnButton_Click(object sender, EventArgs e)
		{

		}

		private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ckbMauChu.Checked)
				this.btnButton.ForeColor = Color.Pink;
			else
				this.btnButton.ForeColor = Color.Purple;
		}

		private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ckbMauNen.Checked)
				this.btnButton.BackColor = Color.LightCyan;
			else
				this.btnButton.BackColor = this.btnButtonFlat.BackColor;
		}

		private void rdFlat_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdFlat.Checked)
				this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
			else
				this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
		}

		private void rdPopup_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
