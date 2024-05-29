namespace CAB.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LastDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastBrowserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastAddressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.FindForYear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.allVisitsBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.FindForTime = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TimeStartBox = new System.Windows.Forms.TextBox();
            this.TimeEndBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.FindForDate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SaveVisitsFile = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.LastDateLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LastBrowserLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LastAddressLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(278, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 128);
            this.panel1.TabIndex = 0;
            // 
            // LastDateLabel
            // 
            this.LastDateLabel.AutoSize = true;
            this.LastDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.LastDateLabel.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDateLabel.ForeColor = System.Drawing.Color.White;
            this.LastDateLabel.Location = new System.Drawing.Point(9, 104);
            this.LastDateLabel.Name = "LastDateLabel";
            this.LastDateLabel.Size = new System.Drawing.Size(103, 15);
            this.LastDateLabel.TabIndex = 8;
            this.LastDateLabel.Text = "Не определенно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label4.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата и время:";
            // 
            // LastBrowserLabel
            // 
            this.LastBrowserLabel.AutoSize = true;
            this.LastBrowserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.LastBrowserLabel.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastBrowserLabel.ForeColor = System.Drawing.Color.White;
            this.LastBrowserLabel.Location = new System.Drawing.Point(9, 64);
            this.LastBrowserLabel.Name = "LastBrowserLabel";
            this.LastBrowserLabel.Size = new System.Drawing.Size(103, 15);
            this.LastBrowserLabel.TabIndex = 7;
            this.LastBrowserLabel.Text = "Не определенно";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Браузер:";
            // 
            // LastAddressLabel
            // 
            this.LastAddressLabel.AutoSize = true;
            this.LastAddressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.LastAddressLabel.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastAddressLabel.ForeColor = System.Drawing.Color.White;
            this.LastAddressLabel.Location = new System.Drawing.Point(9, 24);
            this.LastAddressLabel.Name = "LastAddressLabel";
            this.LastAddressLabel.Size = new System.Drawing.Size(103, 15);
            this.LastAddressLabel.TabIndex = 6;
            this.LastAddressLabel.Text = "Не определенно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label2.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Адрес:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(278, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 31);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Последний посетитель";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.YearTextBox);
            this.panel3.Controls.Add(this.FindForYear);
            this.panel3.Location = new System.Drawing.Point(39, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 76);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label5.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите год:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(113)))));
            this.YearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            this.YearTextBox.Location = new System.Drawing.Point(16, 24);
            this.YearTextBox.MaxLength = 4;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(184, 20);
            this.YearTextBox.TabIndex = 11;
            this.YearTextBox.TabStop = false;
            this.YearTextBox.Text = "YYYY";
            this.YearTextBox.Enter += new System.EventHandler(this.YearTextBox_Enter);
            // 
            // FindForYear
            // 
            this.FindForYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.FindForYear.Location = new System.Drawing.Point(16, 46);
            this.FindForYear.Name = "FindForYear";
            this.FindForYear.Size = new System.Drawing.Size(45, 21);
            this.FindForYear.TabIndex = 9;
            this.FindForYear.TabStop = false;
            this.FindForYear.Text = "Найти";
            this.FindForYear.UseVisualStyleBackColor = true;
            this.FindForYear.Click += new System.EventHandler(this.FindForYear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(39, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 32);
            this.panel4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.label6.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Количество посещений за год";
            // 
            // allVisitsBtn
            // 
            this.allVisitsBtn.Location = new System.Drawing.Point(9, 10);
            this.allVisitsBtn.Name = "allVisitsBtn";
            this.allVisitsBtn.Size = new System.Drawing.Size(97, 21);
            this.allVisitsBtn.TabIndex = 12;
            this.allVisitsBtn.TabStop = false;
            this.allVisitsBtn.Text = "Все посещения";
            this.allVisitsBtn.UseVisualStyleBackColor = true;
            this.allVisitsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.FindForTime);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.TimeStartBox);
            this.panel5.Controls.Add(this.TimeEndBox);
            this.panel5.Location = new System.Drawing.Point(474, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 128);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label9.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Начало:";
            // 
            // FindForTime
            // 
            this.FindForTime.Location = new System.Drawing.Point(58, 90);
            this.FindForTime.Name = "FindForTime";
            this.FindForTime.Size = new System.Drawing.Size(46, 21);
            this.FindForTime.TabIndex = 15;
            this.FindForTime.TabStop = false;
            this.FindForTime.Text = "Найти";
            this.FindForTime.UseVisualStyleBackColor = true;
            this.FindForTime.Click += new System.EventHandler(this.FindForTime_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label8.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Конец:";
            // 
            // TimeStartBox
            // 
            this.TimeStartBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(113)))));
            this.TimeStartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeStartBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStartBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            this.TimeStartBox.Location = new System.Drawing.Point(23, 24);
            this.TimeStartBox.MaxLength = 5;
            this.TimeStartBox.Name = "TimeStartBox";
            this.TimeStartBox.Size = new System.Drawing.Size(125, 20);
            this.TimeStartBox.TabIndex = 13;
            this.TimeStartBox.TabStop = false;
            this.TimeStartBox.Text = "00:00";
            this.TimeStartBox.Enter += new System.EventHandler(this.TimeStartBox_Enter);
            // 
            // TimeEndBox
            // 
            this.TimeEndBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(113)))));
            this.TimeEndBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeEndBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEndBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            this.TimeEndBox.Location = new System.Drawing.Point(23, 64);
            this.TimeEndBox.MaxLength = 5;
            this.TimeEndBox.Name = "TimeEndBox";
            this.TimeEndBox.Size = new System.Drawing.Size(125, 20);
            this.TimeEndBox.TabIndex = 14;
            this.TimeEndBox.TabStop = false;
            this.TimeEndBox.Text = "23:59";
            this.TimeEndBox.Enter += new System.EventHandler(this.TimeEndBox_Enter);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(474, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 31);
            this.panel6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.label7.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Посещения за сутки";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel7.Controls.Add(this.FindForDate);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.DateTextBox);
            this.panel7.Location = new System.Drawing.Point(278, 283);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 76);
            this.panel7.TabIndex = 15;
            // 
            // FindForDate
            // 
            this.FindForDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.FindForDate.Location = new System.Drawing.Point(21, 51);
            this.FindForDate.Name = "FindForDate";
            this.FindForDate.Size = new System.Drawing.Size(45, 21);
            this.FindForDate.TabIndex = 17;
            this.FindForDate.TabStop = false;
            this.FindForDate.Text = "Найти";
            this.FindForDate.UseVisualStyleBackColor = true;
            this.FindForDate.Click += new System.EventHandler(this.FindForDate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label11.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Начало:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(113)))));
            this.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            this.DateTextBox.Location = new System.Drawing.Point(21, 25);
            this.DateTextBox.MaxLength = 10;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(129, 20);
            this.DateTextBox.TabIndex = 17;
            this.DateTextBox.TabStop = false;
            this.DateTextBox.Text = "24-02-2024";
            this.DateTextBox.Enter += new System.EventHandler(this.DateTextBox_Enter);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(278, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(171, 31);
            this.panel8.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.label10.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Найти по дате";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel9.Controls.Add(this.SaveVisitsFile);
            this.panel9.Controls.Add(this.allVisitsBtn);
            this.panel9.Location = new System.Drawing.Point(39, 226);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(214, 76);
            this.panel9.TabIndex = 12;
            // 
            // SaveVisitsFile
            // 
            this.SaveVisitsFile.Location = new System.Drawing.Point(9, 37);
            this.SaveVisitsFile.Name = "SaveVisitsFile";
            this.SaveVisitsFile.Size = new System.Drawing.Size(113, 21);
            this.SaveVisitsFile.TabIndex = 17;
            this.SaveVisitsFile.TabStop = false;
            this.SaveVisitsFile.Text = "Сохранить в файл";
            this.SaveVisitsFile.UseVisualStyleBackColor = true;
            this.SaveVisitsFile.Click += new System.EventHandler(this.SaveVisitsFile_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel10.Controls.Add(this.label12);
            this.panel10.Location = new System.Drawing.Point(39, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(214, 32);
            this.panel10.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.label12.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(68, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Управление";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(684, 427);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LastAddressLabel;
        private System.Windows.Forms.Label LastBrowserLabel;
        private System.Windows.Forms.Label LastDateLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FindForYear;
        private System.Windows.Forms.Button allVisitsBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TimeStartBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FindForTime;
        private System.Windows.Forms.TextBox TimeEndBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button FindForDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveVisitsFile;
    }
}

