using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModifyItems.InitializeFields(this.comboBox2);
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            ModifyItems.RemoveItem(this.comboBox1);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            ModifyItems.RemoveItem(this.comboBox2);
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            ModifyItems.AddItem(this.comboBox1, this.inputBox1);
        }

        private void addItem2_Click(object sender, EventArgs e)
        {
            ModifyItems.AddItem(this.comboBox2, this.inputBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyItems.ChangeTextColor(comboBox1, Color.Black);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyItems.ChangeTextColor(comboBox2, Color.Black);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var orderModel = new OrderModel(new ComboBox[] { this.comboBox1, this.comboBox2 });
            var orderConfirmed = orderModel.ConfirmOrder(orderModel.Message);

            Messages.DisplayOrderConfirmation(orderConfirmed ? "confirmed" : "canceled");
        }
    }
}
