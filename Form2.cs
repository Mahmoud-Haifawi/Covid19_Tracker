using System;
using System.Windows.Forms;
using termProject;
using System.Linq;

namespace termProject
{
    public partial class Form2 : home_screen
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SsnText_TextChanged(object sender, EventArgs e)
        {
           
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            /* Person P = new Person(int.Parse( SsnPer.Text), NameTextBox.Text, NameTextBox.Text, DatePer.Value);
             SystemManager.AddPersone(P);


             MessageBox.Show($"new person has been added to the database. there are {SystemManager.Persons.Count}");
             label3.Enabled = false;*/
        }

        private void newPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DatePer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_TextChanged(object sender, EventArgs e)
        {


        }

        private void Save_Click(object sender, EventArgs e)
        {

            //  (DateTime ShotDate, VACCINE Type, int Lot, Center Vac, String Nurse)
            // VACCINE v = (VACCINE)Enum.Parse(typeof(VACCINE), comboBox1.SelectedItem.ToString());
            //VACCINE v2 = (VACCINE)Enum.Parse(typeof(VACCINE), comboBox1.SelectedItem.ToString());
            string s = "";

            if (SystemManager.Centers.Count!=0)
            {
                var q = from c in SystemManager.Centers
                       
                        select c;

               
                CenterShotOne.DataSource =q;
                MessageBox.Show($"{q}");

            }

            /*CenterShotOne.Items.Clear();
            CenterShotOne.Items.AddRange(SystemManager.Centers.Cast<string>());*/
            //int ID, string Name, String addl1, String addl2, string Phone
            /*Center k = new Center(1, "d", "ddd", "ddddd", "dddddd");
            SystemManager.AddCenter(k);
            VaccineShot Shot1 = new VaccineShot(DateShotOne.Value, v, int.Parse(comboBox3.Text),k , NameNurseShotOne.Text);
            VaccineShot Shot2 = new VaccineShot(DateShotTwo.Value, v2, int.Parse(comboBox3.Text), k, NameNurseShotTwo.Text);
            
            */



            if (int.Parse(SsnPer.Text) <= 0|| SsnPer.Text==""||SsnPer.Text.Length==0)
                MessageBox.Show($"SSN value is not valid please enter it again ");
            else if (NameTextBox.Text == null || NameTextBox.Text == "" || NameTextBox.Text.Length < 2)
            {
                MessageBox.Show($"First name value is not valid please enter it again ");

            }

            else if (textBox1.Text == null|| textBox1.Text == ""|| textBox1.Text.Length<2)
            {
                MessageBox.Show($"Last name value is not valid please enter it again ");

            }
            else if (DatePer.Value == null || DatePer.Value >= DateTime.Today)
                MessageBox.Show($"Birthdate value is not valid please enter it again ");
           
            else
            {
                Person P = new Person(int.Parse(SsnPer.Text), NameTextBox.Text, textBox1.Text, DatePer.Value);
                SystemManager.AddPersone(P);
                MessageBox.Show($"A new person has been added to the database. there are {SystemManager.Persons.Count}");
                Save.Enabled = false;
                if (dateTimePicker1.Value <= DateTime.Today && dateTimePicker2.Value <= DateTime.Today)
                {
                    
                    P.AddInfection(dateTimePicker1.Value);
                    P.AddInfection(dateTimePicker2.Value);
                }



                // SystemManager.VaccinePersoneShot1(P, Shot1);

                // DateTime.InfectionDates dateTimePicker1
            }



        }// VACCINE v = (VACCINE)Enum.Parse(typeof(VACCINE), comboBox1.SelectedItem.ToString());

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            home_screen f = new home_screen();
            f.Show();
        }
        
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TypeShotTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void DateShotOne_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void CenterShotOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CenterShotTwo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

