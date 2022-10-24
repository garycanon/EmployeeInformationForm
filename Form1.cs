using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationForm
{
    public partial class employeeinformationForm : Form
    {
        public employeeinformationForm()
        {
            InitializeComponent();
        }

        
        private void PopulatePrefectures()
        {
            

            if (listBox1.SelectedIndex == 0)
            {
                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Hokkaido");

            }
            //Tohoku
            else if (listBox1.SelectedIndex == 1)
            {

                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Aomori");
                prefectureBox.Items.Add("Iwate");
                prefectureBox.Items.Add("Miyagi");
                prefectureBox.Items.Add("Akita");
                prefectureBox.Items.Add("Yamagata");
                prefectureBox.Items.Add("Fukushima");


            }
            //Kanto
            else if(listBox1.SelectedIndex == 2)
            {
                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Ibaraki");
                prefectureBox.Items.Add("Tochigi");
                prefectureBox.Items.Add("Gunma");
                prefectureBox.Items.Add("Saitama");
                prefectureBox.Items.Add("Chibi");
                prefectureBox.Items.Add("Tokyo");
                prefectureBox.Items.Add("Kanagawa");
            }
            //Chubu
            else if (listBox1.SelectedIndex == 3)
            {

                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Niigata");
                prefectureBox.Items.Add("Toyama");
                prefectureBox.Items.Add("Ishikawa");
                prefectureBox.Items.Add("Fukui");
                prefectureBox.Items.Add("Yamanashi");
                prefectureBox.Items.Add("Nagano");
                prefectureBox.Items.Add("Gifu");
                prefectureBox.Items.Add("Shizuoka");
                prefectureBox.Items.Add("Aichi");


            }
            //Kansai
            else if (listBox1.SelectedIndex == 4)
            {

                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Mie");
                prefectureBox.Items.Add("Shiga");
                prefectureBox.Items.Add("Kyoto");
                prefectureBox.Items.Add("Osaka");
                prefectureBox.Items.Add("Hyogo");
                prefectureBox.Items.Add("Nara");
                prefectureBox.Items.Add("Wakayama");

            }
            //Chugoku
            else if (listBox1.SelectedIndex == 5)
            {
                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Tottori");
                prefectureBox.Items.Add("Shimane");
                prefectureBox.Items.Add("Okayama");
                prefectureBox.Items.Add("Hiroshima");
                prefectureBox.Items.Add("Yamaguchi");

            }
            //Shikoku
            else if (listBox1.SelectedIndex == 6)
            {

                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Tokushima");
                prefectureBox.Items.Add("Kagawa");
                prefectureBox.Items.Add("Ehime");
                prefectureBox.Items.Add("Kouchi");

            }
            //Kyushi
            else if (listBox1.SelectedIndex == 7)
            {

                prefectureBox.Items.Clear();
                prefectureBox.Text = "";
                prefectureBox.Items.Add("Fukuoka");
                prefectureBox.Items.Add("Miyazaki");
                prefectureBox.Items.Add("Nagasaki");
                prefectureBox.Items.Add("Kumamoto");
                prefectureBox.Items.Add("Saga");
                prefectureBox.Items.Add("Oita");
                prefectureBox.Items.Add("Okinawa");
            }
        

    }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string details;
            details = "Employee number: " + maskedNoBox.Text;
            details += "\r\nName: " + nameTBox.Text;
            details += "\r\nAddress: " + addTBox.Text;
            details += "\r\nPrefecture: " + prefectureBox.SelectedItem;
            details += "\r\nRegion: " + listBox1.SelectedItem;
            details += "\r\nDate of Birth: " + dateTimePicker.Value.ToLongDateString();
            details += "\r\nAge: " + ageNumericUpDown.Value.ToString();

            string gender = radioButton1.Checked ? "Male" : "Female";
            details += "\r\nGender: " + gender;

            string hobbies = "";
            foreach (string h in checkedListBox1.CheckedItems)
                hobbies += h + "\r\n\t";

            details += "\r\nHobbies: " + hobbies;

            detailTBox.Text = details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedNoBox.Text = "";
            nameTBox.Text = "";
            addTBox.Text = "";
            prefectureBox.SelectedIndex = -1;
            listBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);

            checkedListBox1.ClearSelected();
            detailTBox.Text = "";
            maskedNoBox.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePrefectures();

        }

        private void prefectureBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var info = new infoForm();
            info.ShowDialog();
        }
    }
}
