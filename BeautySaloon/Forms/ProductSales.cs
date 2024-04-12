using BeautySaloon.Models;
using BeautySaloon.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.Forms
{
	public partial class ProductSales : Form
	{
		private Product _product;
		private ModelBS model;
		private Form1 own;
		public ProductSales(Product product, ModelBS modelBS, Form1 form1)
		{
			InitializeComponent();
			_product = product;
			model = modelBS;
			comboBox1.DataSource = model.Product.ToList();
			own = form1;
		}

		private void ProductSales_Load(object sender, EventArgs e)
		{
			update();
			comboBox1.SelectedItem = _product;
		}
		public void update()
		{
			flowLayoutPanel1.Controls.Clear();
			foreach (ProductSale ps in _product.ProductSale.OrderByDescending(x => x.SaleDate))
			{
				ViewProductSale vps = new ViewProductSale(ps, this, model);
				flowLayoutPanel1.Controls.Add(vps);

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			_product = (Product)comboBox1.SelectedItem;
			update();
		}

		private void ProductSales_FormClosing(object sender, FormClosingEventArgs e)
		{
			own.update();
		}
	}
}
