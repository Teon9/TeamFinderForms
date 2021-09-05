using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TutorialBot
{
    class Teams
    {
        static string filepath1 = @"C:\Users\mrozn\source\repos\TeamFinderForms\TeamFinderForms\bin\Debug\netcoreapp3.1\team1";
        static string filepath2 = @"C:\Users\mrozn\source\repos\TeamFinderForms\TeamFinderForms\bin\Debug\netcoreapp3.1\team2";
        public void LoadPlayers()
        {
           
            
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Path = filepath1;
             fileSystemWatcher.EnableRaisingEvents = true;  
            
            
                
            
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            var team1 = File.ReadAllText(filepath1);
            var team2 = File.ReadAllText(filepath2);
            JsonConvert.DeserializeObject(team1);
            JsonConvert.DeserializeObject(team2);
            
        }


    }
}
