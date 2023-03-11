namespace internshipForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.brnCreate = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdTask = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAssignee = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnReadTask = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteDocumentation = new System.Windows.Forms.Button();
            this.btnUpdateDocumentation = new System.Windows.Forms.Button();
            this.btnReadDocumentation = new System.Windows.Forms.Button();
            this.btnCreateDocumentation = new System.Windows.Forms.Button();
            this.txtIdDocumentation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShowAllTasks = new System.Windows.Forms.Button();
            this.btnCreateStaticTask = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMaxTasks = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.brnCreate);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDoB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(665, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(309, 119);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 28);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(511, 87);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 22);
            this.tbId.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 119);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(417, 119);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // brnCreate
            // 
            this.brnCreate.Location = new System.Drawing.Point(201, 119);
            this.brnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.brnCreate.Name = "brnCreate";
            this.brnCreate.Size = new System.Drawing.Size(100, 28);
            this.brnCreate.TabIndex = 6;
            this.brnCreate.Text = "Create";
            this.brnCreate.UseVisualStyleBackColor = true;
            this.brnCreate.Click += new System.EventHandler(this.brnCreate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(511, 55);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(132, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "monthly salary:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(511, 23);
            this.txtDoB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(132, 22);
            this.txtDoB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "date of birth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(201, 87);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone number: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 55);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdTask);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtIdDoc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAssignee);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtDueDate);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDeleteTask);
            this.groupBox2.Controls.Add(this.btnUpdateTask);
            this.groupBox2.Controls.Add(this.btnReadTask);
            this.groupBox2.Controls.Add(this.btnCreateTask);
            this.groupBox2.Location = new System.Drawing.Point(16, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(665, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // txtIdTask
            // 
            this.txtIdTask.Location = new System.Drawing.Point(511, 103);
            this.txtIdTask.Name = "txtIdTask";
            this.txtIdTask.Size = new System.Drawing.Size(132, 22);
            this.txtIdTask.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(449, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Id:";
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Location = new System.Drawing.Point(201, 86);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(132, 22);
            this.txtIdDoc.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "documentation number:";
            // 
            // txtAssignee
            // 
            this.txtAssignee.Location = new System.Drawing.Point(511, 57);
            this.txtAssignee.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssignee.Name = "txtAssignee";
            this.txtAssignee.Size = new System.Drawing.Size(132, 22);
            this.txtAssignee.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(511, 25);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(132, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(201, 52);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(132, 22);
            this.txtDueDate.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(201, 20);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "assignee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "due date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "description";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(525, 157);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(417, 157);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateTask.TabIndex = 2;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnReadTask
            // 
            this.btnReadTask.Location = new System.Drawing.Point(309, 157);
            this.btnReadTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadTask.Name = "btnReadTask";
            this.btnReadTask.Size = new System.Drawing.Size(100, 28);
            this.btnReadTask.TabIndex = 1;
            this.btnReadTask.Text = "Read";
            this.btnReadTask.UseVisualStyleBackColor = true;
            this.btnReadTask.Click += new System.EventHandler(this.btnReadTask_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(201, 157);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(100, 28);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteDocumentation);
            this.groupBox3.Controls.Add(this.btnUpdateDocumentation);
            this.groupBox3.Controls.Add(this.btnReadDocumentation);
            this.groupBox3.Controls.Add(this.btnCreateDocumentation);
            this.groupBox3.Controls.Add(this.txtIdDocumentation);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtLanguage);
            this.groupBox3.Controls.Add(this.Language);
            this.groupBox3.Controls.Add(this.txtLength);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtProjectName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(16, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 227);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentation";
            // 
            // btnDeleteDocumentation
            // 
            this.btnDeleteDocumentation.Location = new System.Drawing.Point(525, 172);
            this.btnDeleteDocumentation.Name = "btnDeleteDocumentation";
            this.btnDeleteDocumentation.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteDocumentation.TabIndex = 3;
            this.btnDeleteDocumentation.Text = "Delete";
            this.btnDeleteDocumentation.UseVisualStyleBackColor = true;
            this.btnDeleteDocumentation.Click += new System.EventHandler(this.btnDeleteDocumentation_Click);
            // 
            // btnUpdateDocumentation
            // 
            this.btnUpdateDocumentation.Location = new System.Drawing.Point(417, 172);
            this.btnUpdateDocumentation.Name = "btnUpdateDocumentation";
            this.btnUpdateDocumentation.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateDocumentation.TabIndex = 3;
            this.btnUpdateDocumentation.Text = "Update";
            this.btnUpdateDocumentation.UseVisualStyleBackColor = true;
            this.btnUpdateDocumentation.Click += new System.EventHandler(this.btnUpdateDocumentation_Click);
            // 
            // btnReadDocumentation
            // 
            this.btnReadDocumentation.Location = new System.Drawing.Point(309, 172);
            this.btnReadDocumentation.Name = "btnReadDocumentation";
            this.btnReadDocumentation.Size = new System.Drawing.Size(100, 35);
            this.btnReadDocumentation.TabIndex = 3;
            this.btnReadDocumentation.Text = "Read";
            this.btnReadDocumentation.UseVisualStyleBackColor = true;
            this.btnReadDocumentation.Click += new System.EventHandler(this.btnReadDocumentation_Click);
            // 
            // btnCreateDocumentation
            // 
            this.btnCreateDocumentation.Location = new System.Drawing.Point(201, 172);
            this.btnCreateDocumentation.Name = "btnCreateDocumentation";
            this.btnCreateDocumentation.Size = new System.Drawing.Size(102, 35);
            this.btnCreateDocumentation.TabIndex = 5;
            this.btnCreateDocumentation.Text = "Create";
            this.btnCreateDocumentation.UseVisualStyleBackColor = true;
            this.btnCreateDocumentation.Click += new System.EventHandler(this.btnCreateDocumentation_Click);
            // 
            // txtIdDocumentation
            // 
            this.txtIdDocumentation.Location = new System.Drawing.Point(511, 42);
            this.txtIdDocumentation.Name = "txtIdDocumentation";
            this.txtIdDocumentation.Size = new System.Drawing.Size(132, 22);
            this.txtIdDocumentation.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Id";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(201, 114);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(132, 22);
            this.txtLanguage.TabIndex = 3;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(114, 117);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(68, 16);
            this.Language.TabIndex = 4;
            this.Language.Text = "Language";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(201, 78);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(132, 22);
            this.txtLength.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Length";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(201, 36);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(132, 22);
            this.txtProjectName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSort);
            this.groupBox4.Controls.Add(this.btnMaxTasks);
            this.groupBox4.Controls.Add(this.btnShowAllTasks);
            this.groupBox4.Controls.Add(this.btnCreateStaticTask);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(720, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 610);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operations";
            // 
            // btnShowAllTasks
            // 
            this.btnShowAllTasks.Location = new System.Drawing.Point(26, 38);
            this.btnShowAllTasks.Name = "btnShowAllTasks";
            this.btnShowAllTasks.Size = new System.Drawing.Size(341, 30);
            this.btnShowAllTasks.TabIndex = 7;
            this.btnShowAllTasks.Text = "Show All Tasks";
            this.btnShowAllTasks.UseVisualStyleBackColor = true;
            this.btnShowAllTasks.Click += new System.EventHandler(this.btnShowAllTasks_Click);
            // 
            // btnCreateStaticTask
            // 
            this.btnCreateStaticTask.Location = new System.Drawing.Point(26, 225);
            this.btnCreateStaticTask.Name = "btnCreateStaticTask";
            this.btnCreateStaticTask.Size = new System.Drawing.Size(341, 38);
            this.btnCreateStaticTask.TabIndex = 5;
            this.btnCreateStaticTask.Text = "Create Static Task";
            this.btnCreateStaticTask.UseVisualStyleBackColor = true;
            this.btnCreateStaticTask.Click += new System.EventHandler(this.btnCreateStaticTask_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(341, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Show All Tasks Covered In Documentation";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(341, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show All Tasks For Employee";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show All Documentation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Shot All Employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMaxTasks
            // 
            this.btnMaxTasks.Location = new System.Drawing.Point(26, 275);
            this.btnMaxTasks.Name = "btnMaxTasks";
            this.btnMaxTasks.Size = new System.Drawing.Size(341, 33);
            this.btnMaxTasks.TabIndex = 7;
            this.btnMaxTasks.Text = "Employees with max amount of tasks";
            this.btnMaxTasks.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(26, 314);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(341, 28);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort By Salary";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 642);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button brnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnReadTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssignee;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteDocumentation;
        private System.Windows.Forms.Button btnUpdateDocumentation;
        private System.Windows.Forms.Button btnReadDocumentation;
        private System.Windows.Forms.Button btnCreateDocumentation;
        private System.Windows.Forms.TextBox txtIdDocumentation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdTask;
        private System.Windows.Forms.Button btnCreateStaticTask;
        private System.Windows.Forms.Button btnShowAllTasks;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnMaxTasks;
    }
}

