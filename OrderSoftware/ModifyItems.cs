using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSoftware
{
    static class ModifyItems
    {
        public static void ChangeTextColor(ComboBox comboBox, Color color)
        {
            comboBox.ForeColor = color;
        }

        public static void RemoveItem(ComboBox comboBox)
        {
            if (comboBox.Items.Count > 1)
            {
                comboBox.Items.Remove(comboBox.SelectedItem);
                comboBox.SelectedIndex = 0;
            }
        }

        public static void AddItem(ComboBox comboBox, TextBox textBox)
        {
            var item = textBox.Text;

            if (!comboBox.Items.Contains(item.Trim()))
            {
                comboBox.Items.Add(item);
                comboBox.SelectedItem = item;
            }

            textBox.Focus();
            textBox.Text = String.Empty;
        }

        public static void InitializeFields(ComboBox comboBox)
        {
            comboBox.ForeColor = Color.Gray;
            comboBox.Text = "Select food";
           
            comboBox.Items.Add("Pizza");
            comboBox.Items.Add("Burger");
            comboBox.Items.Add("Duner");
            comboBox.Items.Add("Salad");
        }
    }
}
