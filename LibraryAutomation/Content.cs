using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Content : Form
    {
        LibraryAutomation.Library.Controller icontroller;
        public Content()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            icontroller = new LibraryAutomation.Controllers.LA_Test();
        }
    }
}
