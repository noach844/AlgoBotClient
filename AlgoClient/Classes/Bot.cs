using System;
using System.Collections.Generic;
using Microsoft.Win32.TaskScheduler;

namespace AlgoClient.Classes
{
    public class Bot
    {
        public Dictionary<string, string> BotAttributes { get; private set; }
        public Dictionary<string, string> BotTiming { get; private set; }
        
        public Bot()
        {
            BotAttributes = new Dictionary<string, string>();
            BotTiming = new Dictionary<string, string>();

            #region Consts Setup
            BotAttributes.Add("HOST_ADDRESS", "127.0.0.1");
            BotAttributes.Add("PORT", "7496");
            BotAttributes.Add("CLIENT_ID", "123");
            BotAttributes.Add("CURRENCY", "USD");
            BotAttributes.Add("SAMPLE_INTERVAL_SECONDS", "10");
            BotAttributes.Add("RIGHT", "P");
            #endregion                     
        }

        public void AddAttribute(string key, string value)
        {
            if (!BotAttributes.ContainsKey(key))
            {
                BotAttributes.Add(key, value); 
            }
            else
            {
                BotAttributes[key] = value;
            }
        }    
        
        public void AddTimingAttribute(string key, string value)
        {
            if (!BotTiming.ContainsKey(key))
            {
                BotTiming.Add(key, value); 
            }
            else
            {
                BotTiming[key] = value;
            }
        }       

        public void Deploy()
        {
            string resFile;
            CreateConfigFile(out resFile);
            CreateScheduledTask(resFile);
        }

        public void CreateConfigFile(out string path)
        {           
            System.IO.Directory.CreateDirectory("Bots");
            string fileName = $"{BotAttributes["NAME"]}.txt";
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter($"Bots\\{fileName}", append:false);           
            foreach(KeyValuePair<string, string> attribute in BotAttributes)
            {
                string line = $"{attribute.Key}={attribute.Value}";
                streamWriter.WriteLine(line);
            }
            streamWriter.Close();

            path = System.IO.Path.GetFullPath($"Bots\\{fileName}");
        }

        private void CreateScheduledTask(string configPath)
        {
            using (TaskService ts = new TaskService())
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Interactive Brokers Bot.";

                // Create a trigger that will fire the task at this time every other day
                DateTime startTime = DateTime.Parse(BotTiming["TIMING_RUN_TIME"]);
                td.Triggers.Add(new DailyTrigger { DaysInterval = 2, StartBoundary= startTime});

                td.Principal.RunLevel = TaskRunLevel.Highest;
                td.Settings.Hidden = true;
                td.Principal.LogonType = TaskLogonType.S4U;

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction("IBBot.exe", $"--CONFIG={configPath}", null));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition($@"Bots\{BotAttributes["NAME"]}", td);                
            }
        }

        public static Bot LoadBotFromFile(string filePath)
        {
            Bot bot = new Bot();
            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach(string line in lines)
            {
                string[] keyValue = line.Split('=');
                bot.AddAttribute(key: keyValue[0], value: keyValue[1]);
            }

            return bot;
        }
    }
}
