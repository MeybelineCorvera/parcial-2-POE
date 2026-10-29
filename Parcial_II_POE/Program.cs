using System;
using System.Windows.Forms;
using RepoDb;

namespace Parcial_II_POE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            GlobalConfiguration.Setup().UseSqlServer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.Panel());
        }
    }
}
