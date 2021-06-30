using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdvSafeSales
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_Login frm = new frm_Login();
            frm.ShowDialog();

            if(frm.logado == true)
            {
                Application.Run(new frmMenuPrincipal());

            }

            
        }
    }
}
