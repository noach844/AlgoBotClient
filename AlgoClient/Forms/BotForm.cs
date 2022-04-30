using AlgoClient.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoClient.Forms
{
    public partial class BotForm : Form
    {
        private Bot _bot;
        public BotForm(Bot bot)
        {
            _bot = bot;
            InitializeComponent();            
        }

        private void BotForm_Load(object sender, EventArgs e)
        {
            Text = _bot.BotAttributes["NAME"];
            foreach (KeyValuePair<string, string> keyValue in _bot.BotAttributes)
            {
                if(keyValue.Key != "NAME")
                {
                    Label label = new Label();
                    label.Text = $"{keyValue.Key.Replace('_', ' ')}:";
                    label.Dock = DockStyle.Top;
                    label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    label.ForeColor = Color.White;
                    TextBox box = new TextBox();
                    box.Text = keyValue.Value;
                    box.Dock = DockStyle.Top;
                    box.Padding = new Padding(0, 8, 0, 2);
                    box.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    box.Tag = keyValue.Key;
                    LabelsPanel.Controls.Add(label);
                    BoxesPanel.Controls.Add(box);
                }                
            }
        }

        private void AttributesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Bot bot = new Bot();
            bool isValid = true;

            foreach (Control control in BoxesPanel.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (!string.IsNullOrWhiteSpace(control.Text))
                    {
                        bot.AddAttribute((string)control.Tag, control.Text);
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

            }
            if (isValid)
            {
                bot.CreateConfigFile();                
            }
        }
    }
    
}
