using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static TeamFinderForms.Form1;
namespace TeamFinderForms
{
     
    public partial class Form3 : Form
    {
        string nick;
        int numberOfComboBox;
        int index;
        public Form3()
        {
            InitializeComponent();
          
        }
        public  void UpdatePlayers(int NumberOfComboBox, int Index)
        {
            numberOfComboBox = NumberOfComboBox;
            index = Index;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
            if (numberOfComboBox == 1)
            {
                Form1.Instance.listBox1.Items.RemoveAt(index);
                Form1.Instance.listBox1.Items.Add(nick);

            }
            
            if (numberOfComboBox == 2)
            {
                Form1.Instance.listBox2.Items.RemoveAt(index);
                Form1.Instance.listBox2.Items.Add(nick);

            }

            textBox1.Clear();
            this.Hide();
        }
    }
}
