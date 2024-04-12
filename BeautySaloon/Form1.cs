using BeautySaloon.Forms;
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

namespace BeautySaloon
{
	public partial class Form1 : Form
	{
		public ModelBS model = new ModelBS();
		public List<Product> Products = new List<Product>();
		public List<Product> Prod = new List<Product>();
		int prev = 0, current = 1, next = 2, total = 1, size = 20, fullTotal;
		public Form1()
		{
			InitializeComponent();
			Prod = model.Product.ToList();
			left2.Visible = false;
			TotalCount.Visible = false;
			fullTotal = Prod.Count;
			if (Prod.Count > 20)
			{
				total = Prod.Count;
				Products = Prod.GetRange(0, 20);
			}
			else
			{
				right.Visible = false;
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			flowLayoutPanel.Controls.Clear();
			Prod = Prod.Where(x=>x.Title == find.Text || x.Description == find.Text).ToList();
			prev = 0; current = 1; next = 2;

			List<Product> outList = new List<Product>();
			if (Prod.Count > 20)
			{
				total = Prod.Count;
				outList = Prod.GetRange(0, 20);
			}
			else
			{
				total = Prod.Count;
				right.Visible = false;
				outList = Prod;
			}

			foreach (Product p in outList)
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			TotalCount.Visible = true;
			TotalCount.Text = "" + Prod.Count + " из " + fullTotal;
		}

		private void add_Click(object sender, EventArgs e)
		{
			EditProduct ep = new EditProduct(this);
			ep.ShowDialog();
		}

		private void Filter_SelectedIndexChanged(object sender, EventArgs e)
		{
			flowLayoutPanel.Controls.Clear();

			Prod = Products;

			if (Filter.SelectedValue != null)
			{
				Prod = Prod.Where(x => x.ManufacturerID == (int)Filter.SelectedValue).ToList();
			}

			
			prev = 0; current = 1; next = 2;

			List<Product> outList = new List<Product>();
			if (Prod.Count > 20)
			{
				total = Prod.Count;
				outList = Prod.GetRange(0, 20);
			}
			else
			{
				total = Prod.Count;
				right.Visible = false;
				outList = Prod;
			}
			
			foreach (Product p in outList)
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			TotalCount.Visible = true;
			TotalCount.Text = "" + Prod.Count + " из " + fullTotal;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Sort.SelectedIndex = 0;
			manufacturerBindingSource.DataSource = model.Manufacturer.ToList();
			foreach (Product p in Products) {
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			Products = Prod;
		}



		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Prod = Products;
			flowLayoutPanel.Controls.Clear();
			if(Sort.SelectedItem.ToString() == "ID")
			{
				Prod = Prod.OrderBy(x=>x.ID).ToList();
			}
			else if (Sort.SelectedItem.ToString() == "Name(asc)")
			{
				Prod = Prod.OrderBy(x => x.Title).ToList();
			}
			else if(Sort.SelectedItem.ToString() == "Name(desc)")
			{
				Prod = Prod.OrderByDescending(x => x.Title).ToList();
			}
			else if (Sort.SelectedItem.ToString() == "Cost(asc)")
			{
				Prod = Prod.OrderBy(x => x.Cost).ToList();
			}
			else if (Sort.SelectedItem.ToString() == "Cost(desc)")
			{
				Prod = Prod.OrderByDescending(x => x.Cost).ToList();
			}
			prev = 0; current = 1; next = 2;

			foreach (Product p in Prod.GetRange(0, 20))
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}

		}

		private void back_Click(object sender, EventArgs e)
		{
			if(current == 1)
			{
				return;
			}
			flowLayoutPanel.Controls.Clear();
			prev--;
			next--;
			
			foreach (Product p in Prod.GetRange((prev) * 20, size))
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			current--;
			if(current == 1)
			{
				left2.Visible = false;
			}
			left2.Text = prev.ToString();
			center2.Text = current.ToString();
			right.Text = next.ToString();

		}

		private void forward_Click(object sender, EventArgs e)
		{
			if (total < 20)
			{
				return;
			}
			flowLayoutPanel.Controls.Clear();
			prev++;
			
			next++;
			if (total < current * 20)
			{
				size = total - current * 20;
			}
			foreach (Product p in Prod.GetRange((current) * 20, size))
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			current++;
			left2.Visible = true;
			left2.Text = prev.ToString();
			center2.Text = current.ToString();
			right.Text = next.ToString();
			if (total < (current + 1) * 20)
			{
				right.Visible = false;
			}
		}
		public void update()
		{
			flowLayoutPanel.Controls.Clear();
			prev = 0; current = 1; next = 2;
			Prod = model.Product.ToList();
			left2.Visible = false;
			TotalCount.Visible = false;
			fullTotal = Prod.Count;
			List<Product> outList = new List<Product>();
			if (Prod.Count > 20)
			{
				total = Prod.Count;
				outList = Prod.GetRange(0, 20);
			}
			else
			{
				total = Prod.Count;
				right.Visible = false;
				outList = Prod;
			}

			Sort.SelectedIndex = 0;
			foreach (Product p in outList)
			{
				ViewProduct vp = new ViewProduct(p, this, model);
				flowLayoutPanel.Controls.Add(vp);
			}
			Products = Prod;
		}
	}
}
