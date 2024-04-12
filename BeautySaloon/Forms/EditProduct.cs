using BeautySaloon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.Forms
{
	public partial class EditProduct : Form
	{
		Product _product;
		ModelBS model = new ModelBS();
		Form1 own;
		public EditProduct(Product product, Form1 own)
		{
			InitializeComponent();
			_product = product;
			productBindingSource.DataSource = _product;
			this.own = own;
		}
		public EditProduct(Form1 own)
		{
			InitializeComponent();
			_product = new Product();
			productBindingSource.DataSource = _product;
			this.own = own;
		}
		public EditProduct(Product product)
		{
			InitializeComponent();
			_product = product;
			productBindingSource.DataSource = _product;
		}

		private void EditProduct_Load(object sender, EventArgs e)
		{
			manufacturerIDComboBox.DataSource = model.Manufacturer.ToList();
			try
			{
				pictureBox1.Image = Image.FromFile(_product.MainImagePath);
			}
			catch
			{
				pictureBox1.Image = BeautySaloon.Properties.Resources.beauty_logo;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			model.Product.AddOrUpdate(_product);
			model.SaveChanges();
			MessageBox.Show("Сохранено");
		}

		private void EditProduct_FormClosing(object sender, FormClosingEventArgs e)
		{
			own.update();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string filePath;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "JPEG JPG(*.jpeg;*.jpg)|*.jpeg;*.jpg";
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;
					try
					{
						File.Copy(filePath, Application.StartupPath + "\\Товары салона красоты\\" + filePath.Replace("\\", "/").Split('/').Last());
					}
					catch { }

						pictureBox1.Image = Image.FromFile(filePath);

					mainImagePathTextBox.Text = "Товары салона красоты\\" + filePath.Replace("\\", "/").Split('/').Last();
				}
				
			}
		}

		private void manufacturerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			mainImagePathTextBox.Focus();
		}
	}
}
