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
	public partial class ViewProductSale : UserControl
	{
		private ProductSale _ps;
		private ModelBS model;
		private ProductSales _own;
		public ViewProductSale(ProductSale productSale, ProductSales own, ModelBS modelBS)
		{
			InitializeComponent();
			_ps = productSale;
			_own = own;
			model = modelBS;
		}

		private void ViewProductSale_Load(object sender, EventArgs e)
		{
			productSaleBindingSource.DataSource = _ps;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			model.ProductSale.Remove(_ps);
			model.SaveChanges();
			MessageBox.Show("Удалено");
			_own.update();
		}
	}
}
