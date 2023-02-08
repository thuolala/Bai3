using System.ComponentModel;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if(stuID.Text == "" || fullName.Text == "" || 
               comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0 || 
               (semI.Checked == false && semII.Checked == false &&
               semIII.Checked == false && semIV.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                //Get mon hoc  
                String res = "";
                List<string> selectedValues = new List<string>();
                for (int i = 0; i < checkList.Items.Count; i++)
                {
                    if (checkList.GetItemChecked(i))
                        selectedValues.Add(checkList.Items[i].ToString());  
                }

                String selectedSub = ""; 
                for(int j = 0; j < selectedValues.Count; j++)
                {
                    selectedSub += "\n" + (j + 1) + "." + selectedValues[j];
                }

                //Get hoc ky 
                String checkSem = "";
                if (semI.Checked)
                    checkSem += semI.Tag; 
                else if(semII.Checked) 
                    checkSem += semII.Tag;
                else if(semIII.Checked) 
                    checkSem += semIII.Tag;
                else 
                    checkSem += semIV.Tag;

                //Ket qua 
                res += "Sinh viên: " + fullName.Text +
                       "\nLớp: " + comboBox2.SelectedItem.ToString() +
                       "\nNiên khóa: " + comboBox1.SelectedItem.ToString() +
                       "\nĐã đăng ký học: " + checkSem +
                       "\nCác môn học sau: " + selectedSub;

                MessageBox.Show(res, "Đăng ký thành công!");
            }    
        }

        private void del_Click(object sender, EventArgs e)
        {
            stuID.Text = string.Empty;
            fullName.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            //checkList
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                checkList.SetItemChecked(i, false);
            }

            semI.Checked = false;
            semII.Checked = false;
            semIII.Checked = false;
            semIV.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nien khoa 
            var years = new List<string>();
            years.Add("--Select--");
            years.Add("2019");
            years.Add("2020");
            years.Add("2021");
            years.Add("2022");
            years.Add("2023");

            comboBox1.DataSource = years;
            comboBox1.SelectedIndex = 0;

            //Lop

            var classes = new List<string>();
            classes.Add("--Select--");
            classes.Add("TH01");
            classes.Add("TH02");
            classes.Add("TH03");

            comboBox2.DataSource = classes;
            comboBox2.SelectedIndex = 0;

            //Hoc ky 
            semI.Tag = "Học kỳ I";
            semII.Tag = "Học kỳ II";
            semIII.Tag = "Học kỳ III";
            semIV.Tag = "Học kỳ IV";

            panel1.Controls.Add(semI);
            panel1.Controls.Add(semII);
            panel1.Controls.Add(semIII);
            panel1.Controls.Add(semIV);

            //Mon hoc 
            var subjects = new List<string>();
            subjects.Add("IOT cơ bản");
            subjects.Add("Công nghệ Java");
            subjects.Add("Công nghệ phần mềm");
            subjects.Add("Nhập môn trí tuệ nhân tạo");
            subjects.Add("Quản trị mạng");

            checkList.DataSource = subjects;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}