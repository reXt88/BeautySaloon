namespace BeautySaloon.UserControls
{
	partial class ViewProductSale
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label quantityLabel;
			System.Windows.Forms.Label saleDateLabel;
			System.Windows.Forms.Label costLabel;
			System.Windows.Forms.Label titleLabel;
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label iDLabel;
			this.quantityLabel1 = new System.Windows.Forms.Label();
			this.saleDateLabel1 = new System.Windows.Forms.Label();
			this.costLabel1 = new System.Windows.Forms.Label();
			this.titleLabel1 = new System.Windows.Forms.Label();
			this.firstNameLabel1 = new System.Windows.Forms.Label();
			this.lastNameLabel1 = new System.Windows.Forms.Label();
			this.iDLabel1 = new System.Windows.Forms.Label();
			this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button2 = new System.Windows.Forms.Button();
			quantityLabel = new System.Windows.Forms.Label();
			saleDateLabel = new System.Windows.Forms.Label();
			costLabel = new System.Windows.Forms.Label();
			titleLabel = new System.Windows.Forms.Label();
			firstNameLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			iDLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// quantityLabel
			// 
			quantityLabel.AutoSize = true;
			quantityLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			quantityLabel.Location = new System.Drawing.Point(35, 54);
			quantityLabel.Name = "quantityLabel";
			quantityLabel.Size = new System.Drawing.Size(87, 23);
			quantityLabel.TabIndex = 3;
			quantityLabel.Text = "Quantity:";
			// 
			// saleDateLabel
			// 
			saleDateLabel.AutoSize = true;
			saleDateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			saleDateLabel.Location = new System.Drawing.Point(516, 15);
			saleDateLabel.Name = "saleDateLabel";
			saleDateLabel.Size = new System.Drawing.Size(97, 23);
			saleDateLabel.TabIndex = 5;
			saleDateLabel.Text = "Sale Date:";
			// 
			// costLabel
			// 
			costLabel.AutoSize = true;
			costLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			costLabel.Location = new System.Drawing.Point(211, 54);
			costLabel.Name = "costLabel";
			costLabel.Size = new System.Drawing.Size(52, 23);
			costLabel.TabIndex = 7;
			costLabel.Text = "Cost:";
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			titleLabel.Location = new System.Drawing.Point(177, 15);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new System.Drawing.Size(52, 23);
			titleLabel.TabIndex = 9;
			titleLabel.Text = "Title:";
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			firstNameLabel.Location = new System.Drawing.Point(35, 94);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(107, 23);
			firstNameLabel.TabIndex = 10;
			firstNameLabel.Text = "First Name:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lastNameLabel.Location = new System.Drawing.Point(37, 133);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(105, 23);
			lastNameLabel.TabIndex = 12;
			lastNameLabel.Text = "Last Name:";
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			iDLabel.Location = new System.Drawing.Point(35, 15);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(37, 23);
			iDLabel.TabIndex = 13;
			iDLabel.Text = "ID:";
			// 
			// quantityLabel1
			// 
			this.quantityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "Quantity", true));
			this.quantityLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.quantityLabel1.Location = new System.Drawing.Point(128, 54);
			this.quantityLabel1.Name = "quantityLabel1";
			this.quantityLabel1.Size = new System.Drawing.Size(100, 23);
			this.quantityLabel1.TabIndex = 4;
			this.quantityLabel1.Text = "label1";
			// 
			// saleDateLabel1
			// 
			this.saleDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "SaleDate", true));
			this.saleDateLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.saleDateLabel1.Location = new System.Drawing.Point(619, 15);
			this.saleDateLabel1.Name = "saleDateLabel1";
			this.saleDateLabel1.Size = new System.Drawing.Size(123, 23);
			this.saleDateLabel1.TabIndex = 6;
			this.saleDateLabel1.Text = "label1";
			// 
			// costLabel1
			// 
			this.costLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "Product.Cost", true));
			this.costLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.costLabel1.Location = new System.Drawing.Point(269, 54);
			this.costLabel1.Name = "costLabel1";
			this.costLabel1.Size = new System.Drawing.Size(100, 23);
			this.costLabel1.TabIndex = 8;
			this.costLabel1.Text = "label1";
			// 
			// titleLabel1
			// 
			this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "Product.Title", true));
			this.titleLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel1.Location = new System.Drawing.Point(235, 15);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(244, 23);
			this.titleLabel1.TabIndex = 10;
			this.titleLabel1.Text = "label1";
			// 
			// firstNameLabel1
			// 
			this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ClientService.Client.FirstName", true));
			this.firstNameLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.firstNameLabel1.Location = new System.Drawing.Point(148, 94);
			this.firstNameLabel1.Name = "firstNameLabel1";
			this.firstNameLabel1.Size = new System.Drawing.Size(100, 23);
			this.firstNameLabel1.TabIndex = 11;
			this.firstNameLabel1.Text = "None";
			// 
			// lastNameLabel1
			// 
			this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ClientService.Client.LastName", true));
			this.lastNameLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lastNameLabel1.Location = new System.Drawing.Point(150, 133);
			this.lastNameLabel1.Name = "lastNameLabel1";
			this.lastNameLabel1.Size = new System.Drawing.Size(100, 23);
			this.lastNameLabel1.TabIndex = 13;
			this.lastNameLabel1.Text = "None";
			// 
			// iDLabel1
			// 
			this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ID", true));
			this.iDLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iDLabel1.Location = new System.Drawing.Point(78, 15);
			this.iDLabel1.Name = "iDLabel1";
			this.iDLabel1.Size = new System.Drawing.Size(100, 23);
			this.iDLabel1.TabIndex = 14;
			this.iDLabel1.Text = "label1";
			// 
			// productSaleBindingSource
			// 
			this.productSaleBindingSource.DataSource = typeof(BeautySaloon.Models.ProductSale);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(632, 125);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 38);
			this.button2.TabIndex = 15;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ViewProductSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.button2);
			this.Controls.Add(iDLabel);
			this.Controls.Add(this.iDLabel1);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(this.firstNameLabel1);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(this.lastNameLabel1);
			this.Controls.Add(costLabel);
			this.Controls.Add(this.costLabel1);
			this.Controls.Add(titleLabel);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(quantityLabel);
			this.Controls.Add(this.quantityLabel1);
			this.Controls.Add(saleDateLabel);
			this.Controls.Add(this.saleDateLabel1);
			this.Name = "ViewProductSale";
			this.Size = new System.Drawing.Size(745, 173);
			this.Load += new System.EventHandler(this.ViewProductSale_Load);
			((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productSaleBindingSource;
		private System.Windows.Forms.Label quantityLabel1;
		private System.Windows.Forms.Label saleDateLabel1;
		private System.Windows.Forms.Label costLabel1;
		private System.Windows.Forms.Label titleLabel1;
		private System.Windows.Forms.Label firstNameLabel1;
		private System.Windows.Forms.Label lastNameLabel1;
		private System.Windows.Forms.Label iDLabel1;
		private System.Windows.Forms.Button button2;
	}
}
