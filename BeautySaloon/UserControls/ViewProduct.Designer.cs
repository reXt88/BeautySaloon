namespace BeautySaloon.UserControls
{
	partial class ViewProduct
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
			System.Windows.Forms.Label costLabel;
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
			this.costLabel1 = new System.Windows.Forms.Label();
			this.descriptionLabel1 = new System.Windows.Forms.Label();
			this.titleLabel1 = new System.Windows.Forms.Label();
			this.nameLabel1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			costLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// costLabel
			// 
			costLabel.AutoSize = true;
			costLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			costLabel.Location = new System.Drawing.Point(506, 18);
			costLabel.Name = "costLabel";
			costLabel.Size = new System.Drawing.Size(61, 23);
			costLabel.TabIndex = 1;
			costLabel.Text = "Цена:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label1.Location = new System.Drawing.Point(506, 64);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(93, 23);
			label1.TabIndex = 10;
			label1.Text = "Продано:";
			// 
			// costLabel1
			// 
			this.costLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
			this.costLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.costLabel1.Location = new System.Drawing.Point(615, 18);
			this.costLabel1.Name = "costLabel1";
			this.costLabel1.Size = new System.Drawing.Size(100, 39);
			this.costLabel1.TabIndex = 2;
			this.costLabel1.Text = "label1";
			// 
			// descriptionLabel1
			// 
			this.descriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
			this.descriptionLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.descriptionLabel1.Location = new System.Drawing.Point(200, 63);
			this.descriptionLabel1.Name = "descriptionLabel1";
			this.descriptionLabel1.Size = new System.Drawing.Size(258, 54);
			this.descriptionLabel1.TabIndex = 4;
			this.descriptionLabel1.Text = "label1";
			// 
			// titleLabel1
			// 
			this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
			this.titleLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel1.Location = new System.Drawing.Point(196, 18);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(304, 39);
			this.titleLabel1.TabIndex = 8;
			this.titleLabel1.Text = "label1";
			// 
			// nameLabel1
			// 
			this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Manufacturer.Name", true));
			this.nameLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel1.Location = new System.Drawing.Point(196, 126);
			this.nameLabel1.Name = "nameLabel1";
			this.nameLabel1.Size = new System.Drawing.Size(187, 35);
			this.nameLabel1.TabIndex = 9;
			this.nameLabel1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(615, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 39);
			this.label2.TabIndex = 11;
			this.label2.Text = "label1";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(513, 133);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 38);
			this.button1.TabIndex = 12;
			this.button1.Text = "Продажи";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(622, 133);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 38);
			this.button2.TabIndex = 13;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(BeautySaloon.Models.Product);
			// 
			// ViewProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameLabel1);
			this.Controls.Add(costLabel);
			this.Controls.Add(this.costLabel1);
			this.Controls.Add(this.descriptionLabel1);
			this.Controls.Add(this.titleLabel1);
			this.Name = "ViewProduct";
			this.Size = new System.Drawing.Size(743, 183);
			this.Click += new System.EventHandler(this.ViewProduct_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.Label costLabel1;
		private System.Windows.Forms.Label descriptionLabel1;
		private System.Windows.Forms.Label titleLabel1;
		private System.Windows.Forms.Label nameLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
