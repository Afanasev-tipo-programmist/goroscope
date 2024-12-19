using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //переменная месяца
        static public int month {  get; set; }
        //переменная дня
        static public int day {  get; set; }
        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            //переменные дня и месяца
            month = e.Start.Month;
            day = e.Start.Day;
            //включение кнопки результатов
            buttonShowRes.Enabled = true;
            
            
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //запуск 2 формы
            Results frm2 = new Results();
            frm2.Show(this);

            
        }
    }
}
