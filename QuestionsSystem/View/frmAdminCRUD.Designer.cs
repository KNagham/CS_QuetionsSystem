namespace QuestionsSystem.View
{
    partial class frmAdminCRUD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBack_R = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgRead = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtO4 = new System.Windows.Forms.TextBox();
            this.txtO3 = new System.Windows.Forms.TextBox();
            this.txtO2 = new System.Windows.Forms.TextBox();
            this.txtO1 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancel_U = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearch_U = new System.Windows.Forms.Button();
            this.txtID_U = new System.Windows.Forms.TextBox();
            this.btnUpdate_U = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCorrectAnswer_U = new System.Windows.Forms.ComboBox();
            this.txtO4_U = new System.Windows.Forms.TextBox();
            this.txtO3_U = new System.Windows.Forms.TextBox();
            this.txtO2_U = new System.Windows.Forms.TextBox();
            this.txtO1_U = new System.Windows.Forms.TextBox();
            this.txtQuestion_U = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCancel_D = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch_D = new System.Windows.Forms.Button();
            this.txtID_D = new System.Windows.Forms.TextBox();
            this.btnDelete_D = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQuestion_D = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRead)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(80, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBack_R);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.dgRead);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBack_R
            // 
            this.btnBack_R.Location = new System.Drawing.Point(6, 359);
            this.btnBack_R.Name = "btnBack_R";
            this.btnBack_R.Size = new System.Drawing.Size(127, 35);
            this.btnBack_R.TabIndex = 2;
            this.btnBack_R.Text = "Back";
            this.btnBack_R.UseVisualStyleBackColor = true;
            this.btnBack_R.Click += new System.EventHandler(this.btnBack_R_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(635, 359);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(127, 35);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Refreash";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgRead
            // 
            this.dgRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRead.Location = new System.Drawing.Point(6, 6);
            this.dgRead.Name = "dgRead";
            this.dgRead.ReadOnly = true;
            this.dgRead.Size = new System.Drawing.Size(756, 347);
            this.dgRead.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbCorrectAnswer);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.txtO4);
            this.tabPage2.Controls.Add(this.txtO3);
            this.tabPage2.Controls.Add(this.txtO2);
            this.tabPage2.Controls.Add(this.txtO1);
            this.tabPage2.Controls.Add(this.txtQuestion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correct Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Option 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Option 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Option 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Option 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Question";
            // 
            // cbCorrectAnswer
            // 
            this.cbCorrectAnswer.FormattingEnabled = true;
            this.cbCorrectAnswer.Location = new System.Drawing.Point(327, 320);
            this.cbCorrectAnswer.Name = "cbCorrectAnswer";
            this.cbCorrectAnswer.Size = new System.Drawing.Size(121, 21);
            this.cbCorrectAnswer.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(585, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtO4
            // 
            this.txtO4.Location = new System.Drawing.Point(406, 230);
            this.txtO4.Multiline = true;
            this.txtO4.Name = "txtO4";
            this.txtO4.Size = new System.Drawing.Size(281, 51);
            this.txtO4.TabIndex = 4;
            // 
            // txtO3
            // 
            this.txtO3.Location = new System.Drawing.Point(79, 230);
            this.txtO3.Multiline = true;
            this.txtO3.Name = "txtO3";
            this.txtO3.Size = new System.Drawing.Size(281, 51);
            this.txtO3.TabIndex = 3;
            // 
            // txtO2
            // 
            this.txtO2.Location = new System.Drawing.Point(406, 148);
            this.txtO2.Multiline = true;
            this.txtO2.Name = "txtO2";
            this.txtO2.Size = new System.Drawing.Size(281, 51);
            this.txtO2.TabIndex = 2;
            // 
            // txtO1
            // 
            this.txtO1.Location = new System.Drawing.Point(79, 148);
            this.txtO1.Multiline = true;
            this.txtO1.Name = "txtO1";
            this.txtO1.Size = new System.Drawing.Size(281, 51);
            this.txtO1.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(79, 32);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(608, 93);
            this.txtQuestion.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancel_U);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnSearch_U);
            this.tabPage3.Controls.Add(this.txtID_U);
            this.tabPage3.Controls.Add(this.btnUpdate_U);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cbCorrectAnswer_U);
            this.tabPage3.Controls.Add(this.txtO4_U);
            this.tabPage3.Controls.Add(this.txtO3_U);
            this.tabPage3.Controls.Add(this.txtO2_U);
            this.tabPage3.Controls.Add(this.txtO1_U);
            this.tabPage3.Controls.Add(this.txtQuestion_U);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancel_U
            // 
            this.btnCancel_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_U.Location = new System.Drawing.Point(80, 344);
            this.btnCancel_U.Name = "btnCancel_U";
            this.btnCancel_U.Size = new System.Drawing.Size(102, 33);
            this.btnCancel_U.TabIndex = 29;
            this.btnCancel_U.Text = "Cancel";
            this.btnCancel_U.UseVisualStyleBackColor = true;
            this.btnCancel_U.Click += new System.EventHandler(this.btnCancel_U_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "ID";
            // 
            // btnSearch_U
            // 
            this.btnSearch_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_U.Location = new System.Drawing.Point(191, 3);
            this.btnSearch_U.Name = "btnSearch_U";
            this.btnSearch_U.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_U.TabIndex = 27;
            this.btnSearch_U.Text = "Search";
            this.btnSearch_U.UseVisualStyleBackColor = true;
            this.btnSearch_U.Click += new System.EventHandler(this.btnSearch_U_Click);
            // 
            // txtID_U
            // 
            this.txtID_U.Location = new System.Drawing.Point(80, 6);
            this.txtID_U.Name = "txtID_U";
            this.txtID_U.Size = new System.Drawing.Size(100, 20);
            this.txtID_U.TabIndex = 26;
            // 
            // btnUpdate_U
            // 
            this.btnUpdate_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_U.Location = new System.Drawing.Point(586, 344);
            this.btnUpdate_U.Name = "btnUpdate_U";
            this.btnUpdate_U.Size = new System.Drawing.Size(102, 33);
            this.btnUpdate_U.TabIndex = 25;
            this.btnUpdate_U.Text = "Update";
            this.btnUpdate_U.UseVisualStyleBackColor = true;
            this.btnUpdate_U.Click += new System.EventHandler(this.btnUpdate_U_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Correct Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Option 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(188, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Option 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(513, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Option 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Option 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(344, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Question";
            // 
            // cbCorrectAnswer_U
            // 
            this.cbCorrectAnswer_U.Enabled = false;
            this.cbCorrectAnswer_U.FormattingEnabled = true;
            this.cbCorrectAnswer_U.Location = new System.Drawing.Point(328, 344);
            this.cbCorrectAnswer_U.Name = "cbCorrectAnswer_U";
            this.cbCorrectAnswer_U.Size = new System.Drawing.Size(121, 21);
            this.cbCorrectAnswer_U.TabIndex = 18;
            // 
            // txtO4_U
            // 
            this.txtO4_U.Enabled = false;
            this.txtO4_U.Location = new System.Drawing.Point(407, 254);
            this.txtO4_U.Multiline = true;
            this.txtO4_U.Name = "txtO4_U";
            this.txtO4_U.Size = new System.Drawing.Size(281, 51);
            this.txtO4_U.TabIndex = 17;
            // 
            // txtO3_U
            // 
            this.txtO3_U.Location = new System.Drawing.Point(80, 254);
            this.txtO3_U.Multiline = true;
            this.txtO3_U.Name = "txtO3_U";
            this.txtO3_U.Size = new System.Drawing.Size(281, 51);
            this.txtO3_U.TabIndex = 16;
            // 
            // txtO2_U
            // 
            this.txtO2_U.Location = new System.Drawing.Point(407, 172);
            this.txtO2_U.Multiline = true;
            this.txtO2_U.Name = "txtO2_U";
            this.txtO2_U.Size = new System.Drawing.Size(281, 51);
            this.txtO2_U.TabIndex = 15;
            // 
            // txtO1_U
            // 
            this.txtO1_U.Location = new System.Drawing.Point(80, 172);
            this.txtO1_U.Multiline = true;
            this.txtO1_U.Name = "txtO1_U";
            this.txtO1_U.Size = new System.Drawing.Size(281, 51);
            this.txtO1_U.TabIndex = 14;
            // 
            // txtQuestion_U
            // 
            this.txtQuestion_U.Location = new System.Drawing.Point(80, 56);
            this.txtQuestion_U.Multiline = true;
            this.txtQuestion_U.Name = "txtQuestion_U";
            this.txtQuestion_U.Size = new System.Drawing.Size(608, 93);
            this.txtQuestion_U.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCancel_D);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.btnSearch_D);
            this.tabPage4.Controls.Add(this.txtID_D);
            this.tabPage4.Controls.Add(this.btnDelete_D);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtQuestion_D);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCancel_D
            // 
            this.btnCancel_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_D.Location = new System.Drawing.Point(94, 354);
            this.btnCancel_D.Name = "btnCancel_D";
            this.btnCancel_D.Size = new System.Drawing.Size(102, 33);
            this.btnCancel_D.TabIndex = 35;
            this.btnCancel_D.Text = "Cancel";
            this.btnCancel_D.UseVisualStyleBackColor = true;
            this.btnCancel_D.Click += new System.EventHandler(this.btnCancel_D_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "ID";
            // 
            // btnSearch_D
            // 
            this.btnSearch_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_D.Location = new System.Drawing.Point(205, 13);
            this.btnSearch_D.Name = "btnSearch_D";
            this.btnSearch_D.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_D.TabIndex = 33;
            this.btnSearch_D.Text = "Search";
            this.btnSearch_D.UseVisualStyleBackColor = true;
            this.btnSearch_D.Click += new System.EventHandler(this.btnSearch_D_Click);
            // 
            // txtID_D
            // 
            this.txtID_D.Location = new System.Drawing.Point(94, 16);
            this.txtID_D.Name = "txtID_D";
            this.txtID_D.Size = new System.Drawing.Size(100, 20);
            this.txtID_D.TabIndex = 32;
            // 
            // btnDelete_D
            // 
            this.btnDelete_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_D.Location = new System.Drawing.Point(600, 354);
            this.btnDelete_D.Name = "btnDelete_D";
            this.btnDelete_D.Size = new System.Drawing.Size(102, 33);
            this.btnDelete_D.TabIndex = 31;
            this.btnDelete_D.Text = "Delete";
            this.btnDelete_D.UseVisualStyleBackColor = true;
            this.btnDelete_D.Click += new System.EventHandler(this.btnDelete_D_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(358, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Question";
            // 
            // txtQuestion_D
            // 
            this.txtQuestion_D.Location = new System.Drawing.Point(94, 66);
            this.txtQuestion_D.Multiline = true;
            this.txtQuestion_D.Name = "txtQuestion_D";
            this.txtQuestion_D.ReadOnly = true;
            this.txtQuestion_D.Size = new System.Drawing.Size(608, 93);
            this.txtQuestion_D.TabIndex = 29;
            // 
            // frmAdminCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdminCRUD";
            this.Text = "adminCRUD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRead)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtO4;
        private System.Windows.Forms.TextBox txtO3;
        private System.Windows.Forms.TextBox txtO2;
        private System.Windows.Forms.TextBox txtO1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCorrectAnswer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgRead;
        private System.Windows.Forms.Button btnBack_R;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearch_U;
        private System.Windows.Forms.TextBox txtID_U;
        private System.Windows.Forms.Button btnUpdate_U;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCorrectAnswer_U;
        private System.Windows.Forms.TextBox txtO4_U;
        private System.Windows.Forms.TextBox txtO3_U;
        private System.Windows.Forms.TextBox txtO2_U;
        private System.Windows.Forms.TextBox txtO1_U;
        private System.Windows.Forms.TextBox txtQuestion_U;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch_D;
        private System.Windows.Forms.TextBox txtID_D;
        private System.Windows.Forms.Button btnDelete_D;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQuestion_D;
        private System.Windows.Forms.Button btnCancel_U;
        private System.Windows.Forms.Button btnCancel_D;
    }
}