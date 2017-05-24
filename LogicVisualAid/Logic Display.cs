using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LogicVisualAid
{
    public partial class form_PickupDisplay : Form
    {
        public form_PickupDisplay()
        {
            InitializeComponent();
            LoadPickups();
            DisplayPickups();
        }

        private void LoadPickups()
        {

        }

        private static List<Location> GetLocations(string file)
        {
            List<Location> loc_list = new List<Location>();
            return loc_list;
        }

        private void DisplayPickups()
        {
            int XMIN = -1188;
            int XMAX = 914;
            int YMIN = -544;
            int YMAX = 867;

            int XRANGE = XMAX - XMIN;
            int YRANGE = YMAX - YMIN;

            label1.Location = new Point(522, 0 );
            label2.Location = new Point(0, 0);
        }
    }
}
