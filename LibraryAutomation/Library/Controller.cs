using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace LibraryAutomation.Library
{
    class Controller
    {
        /// <summary>
        /// @param datatype view
        /// @param datytype model
        /// </summary>
        public View iview;
        public Model imodel;

        public Controller()
        {
            iview = new View();
            imodel = new Model();
        }
    }
}
