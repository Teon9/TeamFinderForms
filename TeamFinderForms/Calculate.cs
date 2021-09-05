using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static TeamFinderForms.Form1;

namespace TeamFinderForms
{
    class Calculate 
    {

        
        public static void DrawOfNumber(List<string> ListOfPlayers, int number)
        {
            string filepath1 = "team1.txt";
            string filepath2 = "team2.txt";
            var number1 = ListOfPlayers.Count;
            var team1 = new List<string>();
            var team2 = new List<string>();
            RandomizeList.Shuffle(ListOfPlayers);

            for (int i = 0; i < number1; i++)
            {

                if (i % 2 == 0)

                {
                    Instance.listBox1.Items.Add(ListOfPlayers[i]);
                    team1.Add(ListOfPlayers[i]);
                }
                else

                {
                    Instance.listBox2.Items.Add(ListOfPlayers[i]);
                    team2.Add(ListOfPlayers[i]);
                }
            }
            FileManager.InsertToFile(team1, filepath1);
            FileManager.InsertToFile(team2, filepath2);

            
        }
    }   
    
}
            
            



            


            




            
