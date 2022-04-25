﻿using System.Collections.Generic;

namespace AlgoClient.Classes
{
    class Bot
    {
        public Dictionary<string, string> BotAttributes { get; private set; }
        public Bot()
        {
            BotAttributes = new Dictionary<string, string>();

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
            BotAttributes.Add(key, value);
        }

        public void CreateConfigFile()
        {
            System.IO.Directory.CreateDirectory("Bots");
            string fileName = $"{BotAttributes["NAME"]}.txt";
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter($"Bots\\{fileName}", append:true);

            foreach(KeyValuePair<string, string> attribute in BotAttributes)
            {
                string line = $"{attribute.Key}={attribute.Value}";
                streamWriter.WriteLine(line);
            }

            streamWriter.Close();
        }
    }
}