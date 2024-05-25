using CAB.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB.Forms
{
    public partial class VisitsList : Form
    {
        private List<Visit> visits;

        internal VisitsList(List<Visit> list)
        {
            InitializeComponent();

            this.visits = list;
        }

        private void VisitsList_Shown(object sender, EventArgs e)
        {
            foreach (Visit visit in visits)
            {
                ListViewItem item = new ListViewItem(new[] { visit.Ip, visit.Browser, visit.Date });

                VisitsListView.Items.Add(item);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
