using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using static TeamFinderForms.Form1;


namespace TeamFinderForms
{
    class BotManager
    {
        public static Process myProcess = new Process();
        public static void LoadBot()
        {
            
            myProcess.StartInfo.FileName = @"TutorialBot\bin\Debug\netcoreapp3.1\TutorialBot.exe";
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
        }
      
        public static void CloseBot()
        {
            myProcess.Kill();
        }


    }
}
