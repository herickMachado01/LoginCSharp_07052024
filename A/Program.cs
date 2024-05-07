using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
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
            Form1 objForm = new Form1();
            Login ObjLogin = new Login();
            DialogResult resultado = ObjLogin.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Run(objForm);
            }
        }
    }
}
