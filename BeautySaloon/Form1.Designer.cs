namespace BeautySaloon
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.find = new System.Windows.Forms.TextBox();
			this.Sort = new System.Windows.Forms.ComboBox();
			this.Filter = new System.Windows.Forms.ComboBox();
			this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.back = new System.Windows.Forms.Label();
			this.forward = new System.Windows.Forms.Label();
			this.right = new System.Windows.Forms.Label();
			this.center2 = new System.Windows.Forms.Label();
			this.left2 = new System.Windows.Forms.Label();
			this.TotalCount = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Location = new System.Drawing.Point(12, 109);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(776, 376);
			this.flowLayoutPanel.TabIndex = 0;
			// 
			// find
			// 
			this.find.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.find.Location = new System.Drawing.Point(12, 70);
			this.find.Name = "find";
			this.find.Size = new System.Drawing.Size(231, 33);
			this.find.TabIndex = 1;
			this.find.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Sort
			// 
			this.Sort.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Sort.FormattingEnabled = true;
			this.Sort.Items.AddRange(new object[] {
            "ID",
            "Name(asc)",
            "Name(desc)",
            "Cost(asc)",
            "Cost(desc)"});
			this.Sort.Location = new System.Drawing.Point(372, 70);
			this.Sort.Name = "Sort";
			this.Sort.Size = new System.Drawing.Size(170, 33);
			this.Sort.TabIndex = 2;
			this.Sort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Filter
			// 
			this.Filter.DataSource = this.manufacturerBindingSource;
			this.Filter.DisplayMember = "Name";
			this.Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Filter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Filter.FormattingEnabled = true;
			this.Filter.Location = new System.Drawing.Point(548, 70);
			this.Filter.Name = "Filter";
			this.Filter.Size = new System.Drawing.Size(239, 33);
			this.Filter.TabIndex = 3;
			this.Filter.ValueMember = "ID";
			this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
			// 
			// manufacturerBindingSource
			// 
			this.manufacturerBindingSource.DataSource = typeof(BeautySaloon.Models.Manufacturer);
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(678, 488);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(24, 23);
			this.back.TabIndex = 4;
			this.back.Text = "<";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// forward
			// 
			this.forward.AutoSize = true;
			this.forward.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.forward.Location = new System.Drawing.Point(763, 488);
			this.forward.Name = "forward";
			this.forward.Size = new System.Drawing.Size(24, 23);
			this.forward.TabIndex = 6;
			this.forward.Text = ">";
			this.forward.Click += new System.EventHandler(this.forward_Click);
			// 
			// right
			// 
			this.right.AutoSize = true;
			this.right.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.right.Location = new System.Drawing.Point(744, 488);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(20, 23);
			this.right.TabIndex = 8;
			this.right.Text = "2";
			// 
			// center2
			// 
			this.center2.AutoSize = true;
			this.center2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.center2.Location = new System.Drawing.Point(722, 488);
			this.center2.Name = "center2";
			this.center2.Size = new System.Drawing.Size(22, 23);
			this.center2.TabIndex = 5;
			this.center2.Text = "1";
			// 
			// left2
			// 
			this.left2.AutoSize = true;
			this.left2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.left2.Location = new System.Drawing.Point(700, 488);
			this.left2.Name = "left2";
			this.left2.Size = new System.Drawing.Size(20, 23);
			this.left2.TabIndex = 7;
			this.left2.Text = "1";
			// 
			// TotalCount
			// 
			this.TotalCount.AutoSize = true;
			this.TotalCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TotalCount.Location = new System.Drawing.Point(12, 488);
			this.TotalCount.Name = "TotalCount";
			this.TotalCount.Size = new System.Drawing.Size(102, 23);
			this.TotalCount.TabIndex = 11;
			this.TotalCount.Text = "100 из 100";
			// 
			// add
			// 
			this.add.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add.Location = new System.Drawing.Point(12, 26);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(126, 38);
			this.add.TabIndex = 13;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 521);
			this.Controls.Add(this.add);
			this.Controls.Add(this.TotalCount);
			this.Controls.Add(this.right);
			this.Controls.Add(this.left2);
			this.Controls.Add(this.forward);
			this.Controls.Add(this.center2);
			this.Controls.Add(this.back);
			this.Controls.Add(this.Filter);
			this.Controls.Add(this.Sort);
			this.Controls.Add(this.find);
			this.Controls.Add(this.flowLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Beauty saloon";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.TextBox find;
		private System.Windows.Forms.ComboBox Sort;
		private System.Windows.Forms.ComboBox Filter;
		private System.Windows.Forms.Label back;
		private System.Windows.Forms.Label forward;
		private System.Windows.Forms.Label right;
		private System.Windows.Forms.Label center2;
		private System.Windows.Forms.Label left2;
		private System.Windows.Forms.BindingSource manufacturerBindingSource;
		private System.Windows.Forms.Label TotalCount;
		private System.Windows.Forms.Button add;
	}
}

