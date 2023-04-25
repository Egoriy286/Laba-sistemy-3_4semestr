using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Лабораторная_работа_системы_6_1
{
    public partial class Form1 : Form
    {
        int i = 0;
        BindingList<Студент> student = new BindingList<Студент>();
        BindingList<Дисциплина> subject = new BindingList<Дисциплина>();
        public Form1()
        {
            subject.Add(new Дисциплина("Химия      ", " 2  "));
            subject.Add(new Дисциплина("Биология   ", " 3  "));
            subject.Add(new Дисциплина("Алгебра    ", " 4  "));
            subject.Add(new Дисциплина("Информатика", " 5  "));
            InitializeComponent();
            student.Add(new Студент("Корякин   "));
            student.Add(new Студент("Павлова   "));
            student.Add(new Студент("Подорожная"));
            student.Add(new Студент("Жергин    "));
            student.Add(new Студент("Самойлова "));
            student.Add(new Студент("Евдокимов "));

            comboBox1.DataSource = student;
            comboBox1.DisplayMember = "Name";
            comboBox2.DataSource = subject;
            comboBox2.DisplayMember = "Name";
            comboBox3.DataSource = subject;
            comboBox3.DisplayMember = "volHours";
            textBox1.DataBindings.Add(new Binding("Text", student, "Name", true));

        }
        private void ОтобразитьИсточникДанных()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < student.Count; i++)
                listBox1.Items.Add(student[i].Name);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>0)
                listBox1.Items.RemoveAt(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            i++;
            listBox1.Items.Add(comboBox1.Text + " \t" + comboBox2.Text + " \t" + comboBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < comboBox1.Items.Count - 1)
                comboBox1.SelectedIndex += 1;
            else
                if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            student.ResetBindings();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ОтобразитьИсточникДанных();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }
    }
}