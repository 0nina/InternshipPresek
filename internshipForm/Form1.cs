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
                emp.MonthlySalary = Int32.Parse(txtSalary.Text);

                MessageBox.Show("Name : " + emp.Name + "email " + emp.Email + "Date of birth " + emp.DateOfBirth + "phone num " + emp.PhoneNumber);


                s.Save(emp);

                s.Flush();
                s.Close();

                MessageBox.Show(" Employee " + emp.Name + " is now available ");


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
                MessageBox.Show("Employee name: " + employee.Name + " email: " + employee.Email);

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

                if (!String.IsNullOrEmpty(txtName.Text))
                    employee.Name = txtName.Text;

                if (!String.IsNullOrEmpty(txtEmail.Text))
                    employee.Email = txtEmail.Text;

                if (!String.IsNullOrEmpty(txtPhoneNumber.Text))
                    employee.PhoneNumber = txtPhoneNumber.Text;

                if (!String.IsNullOrEmpty(txtDoB.Text))
                    employee.DateOfBirth = Convert.ToDateTime(txtDoB.Text);

                s.Update(employee);

                s.Flush();
                s.Close();

                MessageBox.Show("Employee successfully updated..");

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

                MessageBox.Show("Employee successfully deleted.. ");


                s.Flush();

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
                //MORA DA SE SREDE ID-jevi da ih baza sama dodljuje, u suprotnom je sve ok

                internshipForm.Model.Employee employee = new Model.Employee();
                int idEmployee = Int32.Parse(txtAssignee.Text);

                employee = s.Load<internshipForm.Model.Employee>(idEmployee);

                internshipForm.Model.Documentation doc = new Model.Documentation();
                int idDoc = Int32.Parse(txtIdDoc.Text);
                doc = s.Load<internshipForm.Model.Documentation>(idDoc);

                internshipForm.Model.Task task = new Model.Task();

                task.Title = txtTitle.Text;
                task.DueDate = Convert.ToDateTime(txtDueDate.Text);
                task.Description = txtDescription.Text;
                task.Documentation = doc;
                task.Assignee = employee;

                s.Save(task);


                employee.Tasks.Add(task);
                doc.Tasks.Add(task);


                s.Flush();
                s.Close();

                MessageBox.Show("Task successfully created.. ");
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

                if (task == null)
                    MessageBox.Show("There is no such task");

                MessageBox.Show("Selected task is: " + task.Title + "   Description: " + task.Description);


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

                if (!String.IsNullOrEmpty(txtTitle.Text))
                    task.Title = txtTitle.Text;

                if (!String.IsNullOrEmpty(txtDueDate.Text))
                    task.DueDate = Convert.ToDateTime(txtDueDate.Text);

                if (!String.IsNullOrEmpty(txtDescription.Text))
                    task.Description = txtDescription.Text;


                if (!String.IsNullOrEmpty(txtAssignee.Text))
                {
                    int idAssignee = Int32.Parse(txtAssignee.Text);
                    Employee em = s.Load<internshipForm.Model.Employee>(idAssignee);
                    task.Assignee = em;
                }
                if (!String.IsNullOrEmpty(txtIdDoc.Text))
                {
                    int idDoc = Int32.Parse(txtIdDoc.Text);
                    task.Documentation = s.Load<internshipForm.Model.Documentation>(idDoc);
                }
                s.Update(task);

                s.Flush();
                s.Close();

                MessageBox.Show("Task updated successfully..");

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

                if (String.IsNullOrEmpty(txtIdTask.Text))
                {
                    MessageBox.Show("Enter task id that you wish to delete");
                    return;
                }
                //proveriti
                int idTask = Int32.Parse(txtIdTask.Text);
                Model.Task task = s.Load<internshipForm.Model.Task>(idTask);

                s.Delete(task);
                s.Flush();
                s.Close();
                MessageBox.Show("Task deleted successfully..");

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
                MessageBox.Show("Project name : " + doc.ProjectName + " in language: " + doc.Language);

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

                internshipForm.Model.Documentation d = new Model.Documentation();

                d.Length = Int32.Parse(txtLength.Text);
                d.Language = txtLanguage.Text;
                d.ProjectName = txtProjectName.Text;

                s.Save(d);

                s.Flush();
                s.Close();


                MessageBox.Show("Documentation successfully added.. ");
                MessageBox.Show(" Documentation " + d.ProjectName + " is now available ");

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

                Model.Documentation d = new Model.Documentation() { Language = "c", Length = 45, ProjectName = "Dummy proj" };

                Model.Employee emp = new Model.Employee() { DateOfBirth = DateTime.Today, MonthlySalary = 123456, PhoneNumber = "069242424", Name = "MarcBlack@gmail.com", Email = "markBlack" };

                string iDate = "05/05/2025";
                DateTime oDate = Convert.ToDateTime(iDate);
                Model.Task task = new Model.Task() { Description = "dummy data safajofaifa", DueDate = oDate, Title = "Document n0 8" };

                task.Assignee = emp;
                task.Documentation = d;

                d.Tasks.Add(task);
                emp.Tasks.Add(task);

                s.Save(d);
                s.Save(emp);

                s.Save(task);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnShowAllTasks_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                IList<Model.Task> tasks = s.QueryOver<Model.Task>().List<Model.Task>();

                foreach (Model.Task task in tasks)
                {
                    MessageBox.Show(" Task title: " + task.Title + " description : " + task.Description, "Current tasks");
                }

                s.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDocumentation_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (txtIdDocumentation.Text == null)
                {
                    MessageBox.Show("Enter documentation Id ");
                }

                int idDoc = Int32.Parse(txtIdDocumentation.Text);

                internshipForm.Model.Documentation doc = s.Load<internshipForm.Model.Documentation>(idDoc);


                s.Delete(doc);

                s.Flush();
                s.Close();

                MessageBox.Show("Documentation successfully deleted.. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateDocumentation_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (tbId.Text == null)
                {
                    MessageBox.Show("Enter documentation id that you wish to update");
                    return;
                }

                int idDoc = Int32.Parse(txtIdDocumentation.Text);
                internshipForm.Model.Documentation doc = s.Load<internshipForm.Model.Documentation>(idDoc);

                if (!String.IsNullOrEmpty(txtProjectName.Text))
                    doc.ProjectName = txtProjectName.Text;

                if (!String.IsNullOrEmpty(txtLength.Text))
                    doc.Length = Int32.Parse(txtLength.Text);

                if (!String.IsNullOrEmpty(txtLanguage.Text))
                    doc.Language = txtLanguage.Text;


                s.Update(doc);

                s.Flush();
                s.Close();

                MessageBox.Show("Documentation file successfully updated..");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Employee> employees = s.QueryOver<Employee>().List<Employee>();

                foreach (Employee emp in employees)
                {
                    MessageBox.Show(" Employee name: " + emp.Name + " contact : " + emp.Email, "Current employees");
                }

                s.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTasksEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Model.Task> tasks = s.QueryOver<Model.Task>().Where(x => x.Assignee.Id == 1).List<Model.Task>();

                foreach (Model.Task task in tasks)
                {
                    MessageBox.Show("All available tasks for employee = 1 : " + task.Title + " " + task.Description, "Current tasks of layne");
                }


                s.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmployeesWithTasksInAMonth_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery query = s.CreateSQLQuery("SELECT * FROM EMPLOYEE WHERE ID IN (SELECT ASSIGNEE FROM TASK WHERE DUE_DATE BETWEEN '2023-04-01' AND '2023-04-30' GROUP BY ASSIGNEE)");
                query.AddEntity(typeof(Employee));

                IList<Employee> employees = query.List<Employee>();

                foreach (Employee emp in employees)
                {
                    MessageBox.Show("Employees with tasks in a month: " + emp.Name + " email: " + emp.Email);

                }
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery query = s.CreateSQLQuery("SELECT TOP 3 * FROM EMPLOYEE ORDER BY MONTHLY_SALARY DESC");
                query.AddEntity(typeof(Employee));

                IList<Employee> employees = query.List<Employee>();

                foreach (Employee emp in employees)
                {
                    MessageBox.Show("Employees with highest salaries: " + emp.Name + " email: " + emp.Email);

                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMaxTasks_Click(object sender, EventArgs e)
        {
            /*SELECT * FROM EMPLOYEE WHERE ID IN ( SELECT TOP 2 ASSIGNEE FROM TASK WHERE DUE_DATE BETWEEN '2023-05-01' AND '2023-05-30' GROUP BY ASSIGNEE  ORDER BY COUNT(ID) DESC);*/

            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery query = s.CreateSQLQuery("SELECT * FROM EMPLOYEE WHERE ID IN ( SELECT TOP 5 ASSIGNEE FROM TASK WHERE DUE_DATE BETWEEN '2023-04-01' AND '2023-04-30' GROUP BY ASSIGNEE  ORDER BY COUNT(ID) DESC);");
                query.AddEntity(typeof(Employee));

                IList<Employee> employees = query.List<Employee>();

                foreach (Employee emp in employees)
                {
                    MessageBox.Show("Employees with most completed tasks: " + emp.Name + " email: " + emp.Email);

                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTasksForEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Int32.Parse(tbId.Text);

                ISession s = DataLayer.GetSession();
                IList<Model.Task> tasks = s.QueryOver<Model.Task>().Where(x => x.Assignee.Id == employeeId).List<Model.Task>();

                foreach (Model.Task task in tasks)
                {
                    MessageBox.Show("All available tasks for employee = " + employeeId + " :  " + task.Title + " " + task.Description, "Current tasks of layne");
                }


                s.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMaxTasksDocumentation_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                ISQLQuery query = s.CreateSQLQuery("SELECT * FROM DOCUMENTATION WHERE ID = (SELECT TOP 1 DOCUMENTATION_NUMBER FROM TASK GROUP BY DOCUMENTATION_NUMBER ORDER BY COUNT(DOCUMENTATION_NUMBER) DESC);");
                query.AddEntity(typeof(Documentation));

                IList<Documentation> documentation = query.List<Documentation>();

                foreach (Documentation doc in documentation)
                {
                    MessageBox.Show("Documentation covering maximum amount of tasks: " + doc.ProjectName + " in language: " + doc.Language);

                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAllTasksFromDocumentation_Click(object sender, EventArgs e)
        {
            try
            {
                //input ID in field "Documentation number: " in Tasks section

                ISession s = DataLayer.GetSession();

                int idDocumentation = Int32.Parse(txtIdDoc.Text);

                ISQLQuery query = s.CreateSQLQuery("SELECT * FROM TASK WHERE DOCUMENTATION_NUMBER = " + idDocumentation);

                query.AddEntity(typeof(Model.Task));

                IList<Model.Task> tasks = query.List<Model.Task>();

                foreach (Model.Task task in tasks)
                {
                    MessageBox.Show("All tasks included in documentation number : " + idDocumentation + " Task: " + task.Title + " Description " + task.Description);

                }
                s.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }




    }
}


    
