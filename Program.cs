using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    internal static class Program
    {
        public static Belepes belepes = null;
        public static Form_Orarend formOrarend = null;
        public static int UserId;
        public static Database db = new Database();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            belepes = new Belepes();
            formOrarend = new Form_Orarend();
            Application.Run(belepes);
        }
    }
}
