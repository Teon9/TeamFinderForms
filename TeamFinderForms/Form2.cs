using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeamFinderForms
{
    
    public partial class Form2 : Form
        
    {
        public static Form2 Instance2;
        public Form2()
        {
        Instance2 = this;







        InitializeComponent();
             
        }
        
        public List<string> listOfPlayers = new List<string>();
        int progress;

        



        private void button1_Click_1(object sender, EventArgs e)
        {
            
            



            var nick = textBox1.Text;
            if (textBox1.Text.Length == 0)

                MessageBox.Show("Nie podano nazwy");
            
            else if (textBox1.Text.Length > 15)

                MessageBox.Show("Za długa nazwa (Max 15 znaków)");
            
            else
            {
                listOfPlayers.Add(textBox1.Text);
                var lastIndex = listOfPlayers.LastIndexOf(nick);
                listBox1.Items.Add(listOfPlayers[lastIndex]);

            }
            textBox1.Clear();

            progress = listOfPlayers.Count / Form1.Instance.number;
            




            if (listOfPlayers.Count == Form1.Instance.number)
            {
                button1.Enabled = false;
                this.Hide();
                Calculate.DrawOfNumber(listOfPlayers, Form1.Instance.number);
            }
        }
                



       
    }
}
