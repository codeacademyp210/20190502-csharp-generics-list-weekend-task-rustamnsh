using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int indexRow;

        List<Employee> employees;

        public Form1()
        {
            InitializeComponent();

            employees = new List<Employee>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Employee employee = new Employee
            {
                Name = ad.Text,
                Surname = soyad.Text,
                Email = mail.Text,
                Position = pos.Text,
                Salary = Convert.ToDouble(sal.Text)
            };


            

            employees.Add(employee);


            dataGridView1.Rows.Add(employee.getId(), employee.Name, employee.Surname, employee.Email, employee.Position, employee.Salary);

            //dataGridView1.DataSource = employees;


            ad.Text = string.Empty;
            soyad.Text = string.Empty;
            mail.Text = string.Empty;
            pos.Text = string.Empty;
            sal.Text = string.Empty;


        }



        private void Salary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(sal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                sal.Text = String.Empty;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index


            DataGridViewRow selectedRow = dataGridView1.Rows[indexRow];
            ad.Text = selectedRow.Cells[1].Value.ToString();
            soyad.Text = selectedRow.Cells[2].Value.ToString();
            mail.Text = selectedRow.Cells[3].Value.ToString();
            pos.Text = selectedRow.Cells[4].Value.ToString();
            sal.Text = selectedRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[1].Value = ad.Text;
            newDataRow.Cells[2].Value = soyad.Text;
            newDataRow.Cells[3].Value = mail.Text;
            newDataRow.Cells[4].Value = pos.Text;
            newDataRow.Cells[5].Value = sal.Text;

            ad.Text = String.Empty;
            soyad.Text = String.Empty;
            mail.Text = String.Empty;
            pos.Text = String.Empty;
            sal.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
