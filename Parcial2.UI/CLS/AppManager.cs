using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2.UI.CLS
{
    internal class AppManager : ApplicationContext
    {
        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();

            return Resultado;
        }
        public AppManager()
        {
            if (Splash())
            {
                GUI.Main f = new GUI.Main();
                f.ShowDialog();
            }

        }
    }
}
