using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        void fillList()
        {
           

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Employee employee1 = new Employee();
            employee1.EmployeeId = 1;
            employee1.Name = "John";
            employee1.Surname = "Wick";

            Employee employee2 = new Employee();
            employee2.EmployeeId = 2;
            employee2.Name = "Christian";
            employee2.Surname = "Bale";

            Employee employee3 = new Employee();
            employee3.EmployeeId = 3;
            employee3.Name = "Tom";
            employee3.Surname = "Holland";

            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);

            Days day1 = new Days();
            day1.ID = 1;
            day1.textValue = "sunday";
            dayList.Add(day1);

            Days day2 = new Days();
            day2.ID = 2;
            day2.textValue = "Monday";  
            dayList.Add(day2);

            Days day3 = new Days();
            day3.ID = 3;
            day3.textValue = "Tuesday";
            dayList.Add(day3);

            Days day4 = new Days();
            day4.ID = 4;
            day4.textValue = "Wednesday";
            dayList.Add(day4);

            Days day5 = new Days();
            day5.ID = 5;
            day5.textValue = "Thursday";
            dayList.Add(day5);

            Days day6 = new Days();
            day6.ID = 6;
            day6.textValue = "Friday";
            dayList.Add(day6);

            Days day7 = new Days();
            day7.ID = 7;
            day7.textValue = "Saturday";
            dayList.Add(day7);

            cmbDays.DataSource = dayList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textValue";

            dataGridView1.DataSource = dayList;


          

            
        }

        
        
        List<Employee> list = new List<Employee>();
        List<Days> dayList = new List<Days>();

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in list)
            {
                txtList.Text += item.EmployeeId.ToString() + " " + item.Name + " " + item.Surname + Environment.NewLine;

            }
           
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
