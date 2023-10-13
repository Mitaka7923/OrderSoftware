using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSoftware
{
    class OrderModel
    {
        public List<object> ItemsList { get; set; }
        public string Message { get; set; }

        public OrderModel(ComboBox[] comboBoxes)
        {
            this.ItemsList = this.Generate(comboBoxes[0]);
            this.Message = Messages.GenerateMessage(string.Join(", ", this.ItemsList), new ComboBox[] { comboBoxes[0], comboBoxes[1] });
        }

        public List<object> Generate(ComboBox comboBox)
        {
            var items = new List<object>();

            foreach (var item in comboBox.Items)
            {
                items.Add(item);
            }

            return items;
        }

        public bool ConfirmOrder(string message)
        {
            var orderConfirmed = MessageBox.Show(message, "Order confirmation", MessageBoxButtons.YesNo);

            return orderConfirmed == DialogResult.Yes ? true : false;
        }
    }
}
