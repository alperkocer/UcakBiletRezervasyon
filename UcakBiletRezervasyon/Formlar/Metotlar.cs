using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
   public static class Metotlar
    {
        public static bool BosAlanVarMi(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Trim() == "") return true;
                }               
            }
            return false;
        }

        public static bool BosAlanVarMi2(Panel panelYolcu)
        {
            foreach (Control item in panelYolcu.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Trim() == "") return true;
                }
                else if(item is MaskedTextBox)
                {
                    if (item.Text.Trim() == "") return true;
                }
                else if(item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Date == DateTime.Now.Date)
                        return true;
                }
            }
            return false;
        }

        public static void Temizle(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox) item.Text = "";
                if (item is MaskedTextBox) item.Text = "";
                if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
            }
        }
    }
}
