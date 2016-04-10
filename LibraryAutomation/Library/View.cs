using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryAutomation.Library
{
    class View
    {
        Form v;
        public void Render(Form url, params object[] arg)
        {
            v = url;
            v.Show();
        }
    }
}
