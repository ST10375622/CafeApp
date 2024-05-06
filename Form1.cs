using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeApp
{
	public partial class Form1 : Form
	{

		//define a class to represent an item in the cafe
		public class MenuItem
		{
			public string Name { get; set; }
			public double Price { get; set; }

			public MenuItem(string name, double price)
			{
				Name = name;
				Price = price;
			}

			public override string ToString()
			{
				return Name + " - R" + Price;
			}
		}

		private List<MenuItem> menu = new List<MenuItem>()
		{
			new MenuItem("Cappuccino", 25.00),
			new MenuItem("Espresso", 22.00),
			new MenuItem("Latte", 28.00),
			new MenuItem("Filter Coffee", 18.00),
			new MenuItem("Tea", 15.00),
			new MenuItem("Hot Chocolate", 20.00),
			new MenuItem("Muffin", 15.00),
			new MenuItem("Croissant", 12.00),
			new MenuItem("Sandwich", 30.00),
			new MenuItem("Breakfast", 35.00)
		};

		private List<(string item, int quantity)> order = new List<(string, int)>();


		public Form1()
		{
			InitializeComponent();

			//populate the menu listbox with menu items
			foreach (var item in menu)
			{
				Menu.Items.Add(item);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAddToOrder_Click(object sender, EventArgs e)
		{
			if (Menu.SelectedItem == null)
			{
				MessageBox.Show("Please select an item to add to the order");
				return;
			}

			if (string.IsNullOrEmpty(txtQuantity.Text))
			{
				MessageBox.Show("Please enter a quantity");
				return;
			}

			int quantity;
			if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
			{
				MessageBox.Show("Please enter a valid quantity");
				return;
			}

			MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
			order.Add((selectedItem.Name, quantity));
			MessageBox.Show("Item added to order");
		}



		private void btnDisplayReceiept_Click(object sender, EventArgs e)
		{
			if (order.Count == 0)
			{
				MessageBox.Show("No items in the order");
				return;
			}
			
			double total = 0;
			string receipt = "Receipt:\n\n";

			foreach (var (item, quantity) in order)
			{
				MenuItem menuItem = menu.Find(m => m.Name == item);
				double itemTotal = menuItem.Price * quantity;
				receipt += $"{item} - Quantity: {quantity}, Price per item: R{menuItem.Price},- Total: R{itemTotal}\n";
				total += itemTotal;
			}

			receipt += $"\nTotal: R{total}";

			MessageBox.Show(receipt);
		}
	}
}
