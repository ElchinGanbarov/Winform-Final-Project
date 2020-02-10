using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static bool IsNumber(this string str)
        {
            return Int32.TryParse(str, out int k);
        }

        public static bool IsEmail(this string str)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str);
            if (match.Success)
                return true;
            else
                return false;
        }

    }
}
