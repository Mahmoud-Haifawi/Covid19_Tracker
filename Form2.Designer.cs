
namespace termProject
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.SsnPer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DatePer = new System.Windows.Forms.DateTimePicker();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CenterShotTwo = new System.Windows.Forms.ComboBox();
            this.NameNurseShotTwo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DateShotTwo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CenterShotOne = new System.Windows.Forms.ComboBox();
            this.centerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateShotOne = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NameNurseShotOne = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.centerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SsnPer
            // 
            resources.ApplyResources(this.SsnPer, "SsnPer");
            this.SsnPer.BackColor = System.Drawing.Color.Azure;
            this.SsnPer.Name = "SsnPer";
            this.SsnPer.TextChanged += new System.EventHandler(this.SsnText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::termProject.Properties.Resources.images__1_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Azure;
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.BackColor = System.Drawing.Color.LightGreen;
            this.Save.Name = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.BackColor = System.Drawing.Color.Salmon;
            this.Cancel.Name = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Azure;
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click_1);
            // 
            // DatePer
            // 
            resources.ApplyResources(this.DatePer, "DatePer");
            this.DatePer.CalendarForeColor = System.Drawing.Color.Azure;
            this.DatePer.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DatePer.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DatePer.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.DatePer.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.DatePer.Name = "DatePer";
            this.DatePer.ValueChanged += new System.EventHandler(this.DatePer_ValueChanged);
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.BackColor = System.Drawing.Color.Azure;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Azure;
            this.label18.Name = "label18";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Name = "label2";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Azure;
            this.label11.Name = "label11";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Azure;
            this.label16.Name = "label16";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Name = "label14";
            // 
            // CenterShotTwo
            // 
            resources.ApplyResources(this.CenterShotTwo, "CenterShotTwo");
            this.CenterShotTwo.BackColor = System.Drawing.Color.Azure;
            this.CenterShotTwo.FormattingEnabled = true;
            this.CenterShotTwo.Name = "CenterShotTwo";
            this.CenterShotTwo.SelectedIndexChanged += new System.EventHandler(this.CenterShotTwo_SelectedIndexChanged);
            // 
            // NameNurseShotTwo
            // 
            resources.ApplyResources(this.NameNurseShotTwo, "NameNurseShotTwo");
            this.NameNurseShotTwo.BackColor = System.Drawing.Color.Azure;
            this.NameNurseShotTwo.Name = "NameNurseShotTwo";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Azure;
            this.label15.Name = "label15";
            // 
            // DateShotTwo
            // 
            resources.ApplyResources(this.DateShotTwo, "DateShotTwo");
            this.DateShotTwo.CalendarForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.Name = "DateShotTwo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Name = "label6";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.Name = "label17";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Name = "label9";
            // 
            // CenterShotOne
            // 
            resources.ApplyResources(this.CenterShotOne, "CenterShotOne");
            this.CenterShotOne.BackColor = System.Drawing.Color.Azure;
            this.CenterShotOne.FormattingEnabled = true;
            this.CenterShotOne.Name = "CenterShotOne";
            this.CenterShotOne.SelectedIndexChanged += new System.EventHandler(this.CenterShotOne_SelectedIndexChanged);
            // 
            // centerBindingSource
            // 
            this.centerBindingSource.DataSource = typeof(termProject.Center);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Name = "label8";
            // 
            // DateShotOne
            // 
            resources.ApplyResources(this.DateShotOne, "DateShotOne");
            this.DateShotOne.CalendarForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.Name = "DateShotOne";
            this.DateShotOne.ValueChanged += new System.EventHandler(this.DateShotOne_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Name = "label4";
            // 
            // NameNurseShotOne
            // 
            resources.ApplyResources(this.NameNurseShotOne, "NameNurseShotOne");
            this.NameNurseShotOne.BackColor = System.Drawing.Color.Azure;
            this.NameNurseShotOne.Name = "NameNurseShotOne";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.BackColor = System.Drawing.Color.Azure;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // centerBindingSource1
            // 
            this.centerBindingSource1.DataSource = typeof(termProject.Center);
            // 
            // systemManagerBindingSource
            // 
            this.systemManagerBindingSource.DataSource = typeof(termProject.SystemManager);
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.BackColor = System.Drawing.Color.Azure;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4")});
            this.comboBox2.Name = "comboBox2";
            // 
            // comboBox3
            // 
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.BackColor = System.Drawing.Color.Azure;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1")});
            this.comboBox3.Name = "comboBox3";
            // 
            // comboBox4
            // 
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.BackColor = System.Drawing.Color.Azure;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1")});
            this.comboBox4.Name = "comboBox4";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::termProject.Properties.Resources.eee;
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CenterShotOne);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameNurseShotOne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateShotOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CenterShotTwo);
            this.Controls.Add(this.NameNurseShotTwo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DateShotTwo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DatePer);
            this.Controls.Add(this.SsnPer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Tag = "";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SsnPer, 0);
            this.Controls.SetChildIndex(this.DatePer, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.NameTextBox, 0);
            this.Controls.SetChildIndex(this.Save, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.DateShotTwo, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.NameNurseShotTwo, 0);
            this.Controls.SetChildIndex(this.CenterShotTwo, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.DateShotOne, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.NameNurseShotOne, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.CenterShotOne, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.comboBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SsnPer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Label Cancel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker DatePer;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CenterShotTwo;
        private System.Windows.Forms.TextBox NameNurseShotTwo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DateShotTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CenterShotOne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateShotOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameNurseShotOne;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource centerBindingSource;
        private System.Windows.Forms.BindingSource systemManagerBindingSource;
        private System.Windows.Forms.BindingSource centerBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}