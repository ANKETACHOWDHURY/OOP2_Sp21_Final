
namespace regform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmMonth = new System.Windows.Forms.ComboBox();
            this.cmDay = new System.Windows.Forms.ComboBox();
            this.cmYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReTypeEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReTypePassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmSecurityQues = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSecurityAns = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmState = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtZipOptional = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmMobile = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(264, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(251, 22);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Click += new System.EventHandler(this.FirstName);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(264, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(251, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Of Birth:";
            // 
            // cmMonth
            // 
            this.cmMonth.FormattingEnabled = true;
            this.cmMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April"});
            this.cmMonth.Location = new System.Drawing.Point(264, 135);
            this.cmMonth.Name = "cmMonth";
            this.cmMonth.Size = new System.Drawing.Size(75, 24);
            this.cmMonth.TabIndex = 7;
            this.cmMonth.Text = "Month";
            this.cmMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmDay
            // 
            this.cmDay.FormattingEnabled = true;
            this.cmDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmDay.Location = new System.Drawing.Point(369, 138);
            this.cmDay.Name = "cmDay";
            this.cmDay.Size = new System.Drawing.Size(52, 24);
            this.cmDay.TabIndex = 8;
            this.cmDay.Text = "Day";
            this.cmDay.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmYear
            // 
            this.cmYear.FormattingEnabled = true;
            this.cmYear.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000"});
            this.cmYear.Location = new System.Drawing.Point(458, 135);
            this.cmYear.Name = "cmYear";
            this.cmYear.Size = new System.Drawing.Size(57, 24);
            this.cmYear.TabIndex = 9;
            this.cmYear.Text = "Year";
            this.cmYear.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // cmGender
            // 
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Others"});
            this.cmGender.Location = new System.Drawing.Point(264, 173);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(134, 24);
            this.cmGender.TabIndex = 11;
            this.cmGender.Tag = "";
            this.cmGender.Text = "Choose a gender";
            this.cmGender.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Account Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(106, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "(Your email address will be your username)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(264, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Re-Type Email:";
            // 
            // txtReTypeEmail
            // 
            this.txtReTypeEmail.Location = new System.Drawing.Point(264, 325);
            this.txtReTypeEmail.Name = "txtReTypeEmail";
            this.txtReTypeEmail.Size = new System.Drawing.Size(251, 22);
            this.txtReTypeEmail.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(106, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(264, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 22);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "(Min. 8characters, 1 number,case-sensitive) ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(59, 421);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Re-Type Password:";
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.Location = new System.Drawing.Point(264, 424);
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.Size = new System.Drawing.Size(251, 22);
            this.txtReTypePassword.TabIndex = 22;
            this.txtReTypePassword.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(59, 456);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 23);
            this.label17.TabIndex = 23;
            this.label17.Text = "Security Question:";
            // 
            // cmSecurityQues
            // 
            this.cmSecurityQues.FormattingEnabled = true;
            this.cmSecurityQues.Items.AddRange(new object[] {
            "How are yoy?",
            "What is your Name?"});
            this.cmSecurityQues.Location = new System.Drawing.Point(264, 455);
            this.cmSecurityQues.Name = "cmSecurityQues";
            this.cmSecurityQues.Size = new System.Drawing.Size(251, 24);
            this.cmSecurityQues.TabIndex = 24;
            this.cmSecurityQues.Text = "Choose a security question";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(64, 492);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 23);
            this.label18.TabIndex = 25;
            this.label18.Text = "Security Answer:";
            // 
            // txtSecurityAns
            // 
            this.txtSecurityAns.Location = new System.Drawing.Point(264, 492);
            this.txtSecurityAns.Name = "txtSecurityAns";
            this.txtSecurityAns.Size = new System.Drawing.Size(251, 22);
            this.txtSecurityAns.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(264, 521);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "(Not case-sensitive)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(32, 539);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(235, 28);
            this.label20.TabIndex = 28;
            this.label20.Text = "Contact Information";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(110, 583);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 23);
            this.label21.TabIndex = 29;
            this.label21.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(264, 586);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 22);
            this.txtAddress.TabIndex = 30;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(264, 622);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(251, 22);
            this.txtCity.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(110, 619);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 23);
            this.label22.TabIndex = 31;
            this.label22.Text = "City:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(110, 656);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 23);
            this.label23.TabIndex = 33;
            this.label23.Text = "State:";
            // 
            // cmState
            // 
            this.cmState.FormattingEnabled = true;
            this.cmState.Items.AddRange(new object[] {
            "USA",
            "UK"});
            this.cmState.Location = new System.Drawing.Point(264, 659);
            this.cmState.Name = "cmState";
            this.cmState.Size = new System.Drawing.Size(251, 24);
            this.cmState.TabIndex = 34;
            this.cmState.Text = "Choose a state";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(110, 695);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 23);
            this.label24.TabIndex = 35;
            this.label24.Text = "Zip Code:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(264, 698);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 22);
            this.txtZip.TabIndex = 36;
            // 
            // txtZipOptional
            // 
            this.txtZipOptional.ForeColor = System.Drawing.Color.Gray;
            this.txtZipOptional.Location = new System.Drawing.Point(381, 698);
            this.txtZipOptional.Name = "txtZipOptional";
            this.txtZipOptional.Size = new System.Drawing.Size(100, 22);
            this.txtZipOptional.TabIndex = 37;
            this.txtZipOptional.Text = "Optional";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(110, 736);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 23);
            this.label25.TabIndex = 38;
            this.label25.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(264, 739);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 22);
            this.txtPhone.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(264, 764);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 17);
            this.label26.TabIndex = 40;
            this.label26.Text = "No space or dashes";
            // 
            // cmMobile
            // 
            this.cmMobile.FormattingEnabled = true;
            this.cmMobile.Items.AddRange(new object[] {
            "airtel ",
            "robi",
            "Gp"});
            this.cmMobile.Location = new System.Drawing.Point(449, 736);
            this.cmMobile.Name = "cmMobile";
            this.cmMobile.Size = new System.Drawing.Size(101, 24);
            this.cmMobile.TabIndex = 41;
            this.cmMobile.Text = "Mobile";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(264, 809);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 32);
            this.buttonSubmit.TabIndex = 42;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.SubmitCkick);
            // 
            // rtOutput
            // 
            this.rtOutput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtOutput.Location = new System.Drawing.Point(632, 39);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(388, 519);
            this.rtOutput.TabIndex = 43;
            this.rtOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 853);
            this.Controls.Add(this.rtOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.cmMobile);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtZipOptional);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmState);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSecurityAns);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmSecurityQues);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtReTypePassword);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtReTypeEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmYear);
            this.Controls.Add(this.cmDay);
            this.Controls.Add(this.cmMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmMonth;
        private System.Windows.Forms.ComboBox cmDay;
        private System.Windows.Forms.ComboBox cmYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReTypeEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReTypePassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmSecurityQues;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSecurityAns;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmState;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtZipOptional;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmMobile;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RichTextBox rtOutput;
    }
}

