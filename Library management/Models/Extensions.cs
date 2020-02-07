using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_management.Models
{
   public static class Extensions
    {
        public static bool CheckInput(this Form form)
        {
            var isText = true;
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    var txb = item as TextBox;
                    if (txb.Text.Trim() == "")
                    {
                        isText = false;
                    }
                }
            }

            return isText;
        }
    }
}
