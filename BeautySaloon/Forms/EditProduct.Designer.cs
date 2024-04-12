namespace BeautySaloon.Forms
{
	partial class EditProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label costLabel;
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label isActiveLabel;
			System.Windows.Forms.Label mainImagePathLabel;
			System.Windows.Forms.Label manufacturerIDLabel;
			System.Windows.Forms.Label titleLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
			this.costTextBox = new System.Windows.Forms.TextBox();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.iDTextBox = new System.Windows.Forms.TextBox();
			this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
			this.mainImagePathTextBox = new System.Windows.Forms.TextBox();
			this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
			this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			costLabel = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			iDLabel = new System.Windows.Forms.Label();
			isActiveLabel = new System.Windows.Forms.Label();
			mainImagePathLabel = new System.Windows.Forms.Label();
			manufacturerIDLabel = new System.Windows.Forms.Label();
			titleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// costLabel
			// 
			costLabel.AutoSize = true;
			costLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			costLabel.Location = new System.Drawing.Point(556, 55);
			costLabel.Name = "costLabel";
			costLabel.Size = new System.Drawing.Size(59, 25);
			costLabel.TabIndex = 1;
			costLabel.Text = "Cost:";
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			descriptionLabel.Location = new System.Drawing.Point(60, 152);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(123, 25);
			descriptionLabel.TabIndex = 3;
			descriptionLabel.Text = "Description:";
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			iDLabel.Location = new System.Drawing.Point(60, 55);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(41, 25);
			iDLabel.TabIndex = 5;
			iDLabel.Text = "ID:";
			// 
			// isActiveLabel
			// 
			isActiveLabel.AutoSize = true;
			isActiveLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			isActiveLabel.Location = new System.Drawing.Point(556, 108);
			isActiveLabel.Name = "isActiveLabel";
			isActiveLabel.Size = new System.Drawing.Size(99, 25);
			isActiveLabel.TabIndex = 7;
			isActiveLabel.Text = "Is Active:";
			// 
			// mainImagePathLabel
			// 
			mainImagePathLabel.AutoSize = true;
			mainImagePathLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			mainImagePathLabel.Location = new System.Drawing.Point(60, 265);
			mainImagePathLabel.Name = "mainImagePathLabel";
			mainImagePathLabel.Size = new System.Drawing.Size(179, 25);
			mainImagePathLabel.TabIndex = 9;
			mainImagePathLabel.Text = "Main Image Path:";
			// 
			// manufacturerIDLabel
			// 
			manufacturerIDLabel.AutoSize = true;
			manufacturerIDLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			manufacturerIDLabel.Location = new System.Drawing.Point(60, 206);
			manufacturerIDLabel.Name = "manufacturerIDLabel";
			manufacturerIDLabel.Size = new System.Drawing.Size(173, 25);
			manufacturerIDLabel.TabIndex = 11;
			manufacturerIDLabel.Text = "Manufacturer ID:";
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			titleLabel.Location = new System.Drawing.Point(60, 103);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new System.Drawing.Size(59, 25);
			titleLabel.TabIndex = 13;
			titleLabel.Text = "Title:";
			// 
			// costTextBox
			// 
			this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
			this.costTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.costTextBox.Location = new System.Drawing.Point(652, 52);
			this.costTextBox.Name = "costTextBox";
			this.costTextBox.Size = new System.Drawing.Size(135, 33);
			this.costTextBox.TabIndex = 2;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(BeautySaloon.Models.Product);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
			this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.descriptionTextBox.Location = new System.Drawing.Point(257, 154);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(213, 33);
			this.descriptionTextBox.TabIndex = 4;
			// 
			// iDTextBox
			// 
			this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
			this.iDTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iDTextBox.Location = new System.Drawing.Point(257, 52);
			this.iDTextBox.Name = "iDTextBox";
			this.iDTextBox.ReadOnly = true;
			this.iDTextBox.Size = new System.Drawing.Size(213, 33);
			this.iDTextBox.TabIndex = 6;
			// 
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
			this.isActiveCheckBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isActiveCheckBox.Location = new System.Drawing.Point(661, 105);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(135, 40);
			this.isActiveCheckBox.TabIndex = 8;
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// mainImagePathTextBox
			// 
			this.mainImagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MainImagePath", true));
			this.mainImagePathTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mainImagePathTextBox.Location = new System.Drawing.Point(257, 263);
			this.mainImagePathTextBox.Name = "mainImagePathTextBox";
			this.mainImagePathTextBox.Size = new System.Drawing.Size(213, 33);
			this.mainImagePathTextBox.TabIndex = 10;
			// 
			// manufacturerIDComboBox
			// 
			this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ManufacturerID", true));
			this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
			this.manufacturerIDComboBox.DisplayMember = "ID";
			this.manufacturerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.manufacturerIDComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.manufacturerIDComboBox.FormattingEnabled = true;
			this.manufacturerIDComboBox.Location = new System.Drawing.Point(257, 203);
			this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
			this.manufacturerIDComboBox.Size = new System.Drawing.Size(213, 33);
			this.manufacturerIDComboBox.TabIndex = 12;
			this.manufacturerIDComboBox.ValueMember = "ID";
			this.manufacturerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.manufacturerIDComboBox_SelectedIndexChanged);
			// 
			// manufacturerBindingSource
			// 
			this.manufacturerBindingSource.DataSource = typeof(BeautySaloon.Models.Manufacturer);
			// 
			// titleTextBox
			// 
			this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
			this.titleTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleTextBox.Location = new System.Drawing.Point(257, 102);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(213, 33);
			this.titleTextBox.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(719, 400);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 38);
			this.button1.TabIndex = 15;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::BeautySaloon.Properties.Resources.beauty_logo;
			this.pictureBox1.Location = new System.Drawing.Point(561, 179);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 172);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// EditProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(costLabel);
			this.Controls.Add(this.costTextBox);
			this.Controls.Add(descriptionLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(iDLabel);
			this.Controls.Add(this.iDTextBox);
			this.Controls.Add(isActiveLabel);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(mainImagePathLabel);
			this.Controls.Add(this.mainImagePathTextBox);
			this.Controls.Add(manufacturerIDLabel);
			this.Controls.Add(this.manufacturerIDComboBox);
			this.Controls.Add(titleLabel);
			this.Controls.Add(this.titleTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditProduct";
			this.Text = "EditProduct";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProduct_FormClosing);
			this.Load += new System.EventHandler(this.EditProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.TextBox costTextBox;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.TextBox iDTextBox;
		private System.Windows.Forms.CheckBox isActiveCheckBox;
		private System.Windows.Forms.TextBox mainImagePathTextBox;
		private System.Windows.Forms.ComboBox manufacturerIDComboBox;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource manufacturerBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}