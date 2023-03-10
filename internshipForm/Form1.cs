using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using internshipForm.Model;

namespace internshipForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void brnCreate_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession s = DataLayer.GetSession();

                Model.Employee emp = new Model.Employee();

                emp.Name = txtName.Text;
                emp.Email = txtEmail.Text;
                emp.DateOfBirth = txtDoB.Text;
                emp.PhoneNumber = txtPhoneNumber.Text;

                s.Save(emp);

                s.Flush();
                s.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession s = DataLayer.GetSession();

                if (tbId.Text == null)
                    MessageBox.Show("Enter employee Id ");

                int idEmployee = Int32.Parse(tbId.Text);

                internshipForm.Model.Employee employee = s.Load<internshipForm.Model.Employee>(idEmployee);
                MessageBox.Show(employee.Name, employee.Email);
                
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //prvo ucitavanje 
            try
            {
                ISession s = DataLayer.GetSession();

                if (tbId.Text == null)
                    MessageBox.Show("Enter employee id that you wish to update");

                int idEmployee = Int32.Parse(tbId.Text);
                internshipForm.Model.Employee employee = s.Load<internshipForm.Model.Employee>(idEmployee);

                if (txtName.Text != null)
                    employee.Name = txtName.Text;
                if (txtEmail.Text != null)
                    employee.Email = txtEmail.Text;
                if (txtPhoneNumber.Text != null)
                    employee.PhoneNumber = txtPhoneNumber.Text;
                if (txtDoB.Text != null)
                    employee.DateOfBirth = txtDoB.Text;

                s.Update(employee);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (tbId.Text == null)
                    MessageBox.Show("Enter employee Id ");

                int idEmployee = Int32.Parse(tbId.Text);

                internshipForm.Model.Employee employee = s.Load<internshipForm.Model.Employee>(idEmployee);
               
                s.Delete(employee);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //pribavljanje employee-a kome treba dodeliti task
                internshipForm.Model.Employee employee = new Model.Employee();
                int idEmployee = Int32.Parse(tbId.Text);
                
                employee = s.Load<internshipForm.Model.Employee>(idEmployee);


                internshipForm.Model.Task task = new Model.Task();
                task.Title = txtTitle.Text;
                task.DueDate = txtDueDate.Text;
                task.Description = txtDescription.Text;

                employee.Tasks.Add(task);


                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReadTask_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Model.Task task = new Model.Task();
                int idTask = Int32.Parse(txtIdTask.Text);
                task = s.Load<internshipForm.Model.Task>(idTask);

                MessageBox.Show(task.Title); 


                s.Close();
            }
            catch(Exception ex)
            {

            }
        }


    }
}
