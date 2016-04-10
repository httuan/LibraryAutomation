using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.Controllers
{
    class LA_Test : LibraryAutomation.Library.Controller
    {


        public LA_Test()
        {
            Form f = new LibraryAutomation.Views.LA_Test();
            base.iview.Render(f);
        }
    }
}