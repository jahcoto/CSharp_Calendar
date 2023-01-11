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

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            txtBirthDay.Text = txtBirthDate.Text.Substring(0,2);
            txtBirthMonth.Text = txtBirthDate.Text.Substring(3,2);
            int i = txtBirthDate.Text.Length;
            txtBirthYear.Text = txtBirthDate.Text.Substring(i-4, 4);
            int month;  int.TryParse(txtBirthMonth.Text, out month);
            
            
            lblBirthMonth.Text = monthNumName(month);
        }
    }

    public string monthNumName(int monthNumber) 
    {
        string monthText = "";
        switch (monthNumber)
        {
            case 1:
                monthText = "January";
                break;
            case 2:
                monthText = "February";
                break;
            case 3:
                monthText = "March";
                break;
            case 4:
                monthText = "Abril";
                break;
            case 5:
                monthText = "May";
                break;
            case 6:
                monthText = "June";
                break;
            case 7:
                monthText = "July";
                break;
            case 8:
                monthText = "August";
                break;
            case 9:
                monthText = "September";
                break;
            case 10:
                monthText = "October";
                break;
            case 11:
                monthText = "November";
                break;
            case 12:
                monthText = "December";
                break;
        }

        return monthText;
    }
}
