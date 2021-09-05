using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TutorialBot;

namespace TeamFinderForms
{

    public partial class Form1 : Form
    {
        private Regex Regex = new Regex("^([1-9][0-9]*)$");
        public static Form1 Instance;
        public int BotNumber;
        Form2 form2 = new Form2();

        Form3 form3 = new Form3();
        public int index;
        public int comboBoxNumber;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            form2.Activate();

            BotManager.LoadBot();
        }
        public int number;


        public void button1_Click(object sender, EventArgs e)
        {
            number = int.Parse(textBox1.Text);
            form2.Show();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            string text = textBox1.Text + e.KeyChar;
            if (Regex.IsMatch(text))
            {

                textBox1.Text = text;

            }
            else if (textBox1.Text.Length > 0 && e.KeyChar == ((char)Keys.Back))
            {
                string text2 = textBox1.Text;
                text2 = text2.Remove(text2.Length - 1);
                textBox1.Text = text2;
            }
            textBox1.SelectionStart = text.Length;
            e.Handled = true;
        }



        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;

            comboBoxNumber = 1;
            form3.Show();

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex + 1;
            comboBoxNumber = 2;

            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Calculate.DrawOfNumber(Form2.Instance2.listOfPlayers, number);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            form3.UpdatePlayers(index, 1);
            form3.Show();
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var index = listBox2.SelectedIndex;
            form3.UpdatePlayers(index, 2);
            form3.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BotManager.CloseBot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

            


           
     

