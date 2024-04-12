using BeautySaloon.Forms;
using BeautySaloon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.UserControls
{
	public partial class ViewProduct : UserControl
	{
		public Product _product;
		private Form1 own;
		private ModelBS model;
		public ViewProduct(Product product, Form1 form, ModelBS model)
		{
			InitializeComponent();
			_product = product;
			this.own = form;
			Fill();
			this.model = model;
		}

		public void Fill()
		{
			productBindingSource.DataSource = _product;
			try
			{
				pictureBox1.Image = Image.FromFile(_product.MainImagePath);
			}
			catch
			{
				pictureBox1.Image = BeautySaloon.Properties.Resources.beauty_logo;
			}
			if (_product.IsActive)
			{
				this.BackColor = Color.White;
			}
			else
			{
				this.BackColor = Color.Gray;
			}
			DateTime date = DateTime.Now.AddDays(30.0);
			List<ProductSale> ps = _product.ProductSale.Where(x => x.SaleDate < date).ToList();
			label2.Text = (_product.Cost * ps.Count).ToString();
		}

		private void ViewProduct_Click(object sender, EventArgs e)
		{
			EditProduct ep = new EditProduct(_product, own);
			ep.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ProductSales ps = new ProductSales(_product, model, own);
			ps.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			model.Product.Remove(_product);
			model.SaveChanges();
			MessageBox.Show("Удалено");
			own.update();
		}
	}
}
