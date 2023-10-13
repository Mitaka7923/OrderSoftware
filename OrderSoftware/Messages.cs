using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSoftware
{
    static class Messages
    {
        public static string GenerateMessage(string selectedExtras, ComboBox[] comboBoxes)
        {
            var message = $"You have ordered a {comboBoxes[1].SelectedItem} with [0].";

            if (comboBoxes[0].Text != "Additional extras")
            {
                message = message.Replace("[0]", $"an additional extras of {selectedExtras}");
            }
            else
            {
                message = message.Replace("[0]", "with no additional extras");
            }

            return message;
        }

        public static void DisplayOrderConfirmation(string text)
        {
            MessageBox.Show($"Order is {text}.", "Order confirmed");
        }
    }
}
