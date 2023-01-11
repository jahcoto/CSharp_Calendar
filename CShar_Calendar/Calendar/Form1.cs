using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            System.Globalization.GregorianCalendar gCal = new System.Globalization.GregorianCalendar();
            txtYear.Text = gCal.GetYear(DateTime.Now).ToString();
            txtMonth.Text = gCal.GetMonth(DateTime.Now).ToString();
            txtDay.Text = gCal.GetDayOfMonth(DateTime.Now).ToString();

        }
    }
}
