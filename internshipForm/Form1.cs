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
                emp.DateOfBirth = Convert.ToDateTime(txtDoB.Text);
                emp.PhoneNumber = txtPhoneNumber.Text;

                s.Save(emp);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
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
                MessageBox.Show(employee.Name + " " + employee.Email);

                s.Close();
            }
            catch (Exception ex)
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
                {
                    MessageBox.Show("Enter employee id that you wish to update");
                    return;
                }

                int idEmployee = Int32.Parse(tbId.Text);
                internshipForm.Model.Employee employee = s.Load<internshipForm.Model.Employee>(idEmployee);

                if (txtName.Text != null)
                    employee.Name = txtName.Text;
                if (txtEmail.Text != null)
                    employee.Email = txtEmail.Text;
                if (txtPhoneNumber.Text != null)
                    employee.PhoneNumber = txtPhoneNumber.Text;
                if (txtDoB.Text != null)
                    employee.DateOfBirth = Convert.ToDateTime(txtDoB.Text);

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
                {
                    MessageBox.Show("Enter employee Id ");
                    return;
                }

                int idEmployee = Int32.Parse(tbId.Text);

                internshipForm.Model.Employee employee = s.Load<internshipForm.Model.Employee>(idEmployee);

                s.Delete(employee);
                s.Close();
            }
            catch (Exception ex)
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
                int idEmployee = Int32.Parse(txtIdEmployee.Text);

                employee = s.Load<internshipForm.Model.Employee>(idEmployee);

                internshipForm.Model.Documentation doc = new Model.Documentation();
                int idDoc = Int32.Parse(txtIdDoc.Text);
                doc = s.Load<internshipForm.Model.Documentation>(idDoc);

                internshipForm.Model.Task task = new Model.Task();

                task.Title = txtTitle.Text;
                task.DueDate = Convert.ToDateTime(txtDueDate.Text);
                task.Description = txtDescription.Text;

                employee.Tasks.Add(task);
                doc.Tasks.Add(task);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (txtIdTask.Text == null)
                {
                    MessageBox.Show("Enter task id that you wish to update");
                    return;
                }
                int idTask = Int32.Parse(txtIdTask.Text);
                internshipForm.Model.Task task = s.Load<internshipForm.Model.Task>(idTask);

                if (txtTitle.Text != null)
                    task.Title = txtTitle.Text;
                if (txtDescription.Text != null)
                    task.Description = txtDescription.Text;
                if (txtDueDate.Text != null)
                    task.DueDate = Convert.ToDateTime(txtDueDate.Text);

                //Convert.ToDateTime(iDate)
                //assignee
                if (txtAssignee.Text != null)
                {
                    int idAssignee = Int32.Parse(txtAssignee.Text);
                    task.Assignee = s.Load<internshipForm.Model.Employee>(idAssignee);

                }
                if (txtIdDoc.Text != null)
                {
                    int idDoc = Int32.Parse(txtIdDoc.Text);
                }
                s.Update(task);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (txtIdEmployee == null)
                {
                    MessageBox.Show("Enter task id that you wish to delete");
                    return;
                }
                int idTask = Int32.Parse(txtIdEmployee.Text);
                Model.Task task = s.Load<internshipForm.Model.Task>(idTask);

                s.Delete(task);
                s.Flush();
                s.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnReadDocumentation_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (txtIdDocumentation.Text == null)
                    MessageBox.Show("Enter documentation Id ");

                int IdDocumentation = Int32.Parse(txtIdDocumentation.Text);

                internshipForm.Model.Documentation doc = s.Load<internshipForm.Model.Documentation>(IdDocumentation);
                MessageBox.Show(doc.ProjectName + " " + doc.Language);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDocumentation_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //dokumentacija ima vise 
                internshipForm.Model.Documentation d = new Model.Documentation();

                int idDoc = Int32.Parse(txtIdDocumentation.Text);

                d.Length = Int32.Parse(txtLength.Text);
                d.Language = txtLanguage.Text;
                d.ProjectName = txtProjectName.Text;

                s.Save(d);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnCreateStaticTask_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Model.Documentation d = new Model.Documentation() {  Language = "c", Length = 45, ProjectName = "Dummy proj" };

                Model.Employee emp = new Model.Employee() { DateOfBirth = DateTime.Today, MonthlySalary = 123456, PhoneNumber = "069242424", Name = "MarcBlack@gmail.com", Email = "markBlack" };

                string iDate = "05/05/2025";
                DateTime oDate = Convert.ToDateTime(iDate);
                Model.Task task = new Model.Task() { Description = "dummy data safajofaifa", DueDate = oDate, Title = "Document n0 8" };

                d.Tasks.Add(task);
                emp.Tasks.Add(task);
                
                s.Save(d);
                s.Save(emp);

                task.Assignee = emp;
                task.Documentation = d;

                s.Save(task);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}