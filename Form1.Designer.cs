namespace CafeApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			Menu = new ListBox();
			label3 = new Label();
			txtQuantity = new TextBox();
			btnAddToOrder = new Button();
			btnDisplayReceiept = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(305, 21);
			label1.Name = "label1";
			label1.Size = new Size(147, 40);
			label1.TabIndex = 1;
			label1.Text = "Cafe App";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(64, 107);
			label2.Name = "label2";
			label2.Size = new Size(120, 28);
			label2.TabIndex = 2;
			label2.Text = "Menu Item:";
			// 
			// Menu
			// 
			Menu.FormattingEnabled = true;
			Menu.Location = new Point(64, 154);
			Menu.Name = "Menu";
			Menu.Size = new Size(120, 24);
			Menu.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(449, 107);
			label3.Name = "label3";
			label3.Size = new Size(100, 28);
			label3.TabIndex = 4;
			label3.Text = "Quantity:";
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(431, 154);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(154, 27);
			txtQuantity.TabIndex = 5;
			// 
			// btnAddToOrder
			// 
			btnAddToOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAddToOrder.Location = new Point(64, 296);
			btnAddToOrder.Name = "btnAddToOrder";
			btnAddToOrder.Size = new Size(120, 72);
			btnAddToOrder.TabIndex = 6;
			btnAddToOrder.Text = "Add To Order";
			btnAddToOrder.UseVisualStyleBackColor = true;
			btnAddToOrder.Click += btnAddToOrder_Click;
			// 
			// btnDisplayReceiept
			// 
			btnDisplayReceiept.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDisplayReceiept.Location = new Point(427, 296);
			btnDisplayReceiept.Name = "btnDisplayReceiept";
			btnDisplayReceiept.Size = new Size(158, 72);
			btnDisplayReceiept.TabIndex = 7;
			btnDisplayReceiept.Text = "Display Reciept";
			btnDisplayReceiept.UseVisualStyleBackColor = true;
			btnDisplayReceiept.Click += btnDisplayReceiept_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 64, 0);
			ClientSize = new Size(800, 450);
			Controls.Add(btnDisplayReceiept);
			Controls.Add(btnAddToOrder);
			Controls.Add(txtQuantity);
			Controls.Add(label3);
			Controls.Add(Menu);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ListBox Menu;
		private Label label3;
		private TextBox txtQuantity;
		private Button btnAddToOrder;
		private Button btnDisplayReceiept;
	}
}
