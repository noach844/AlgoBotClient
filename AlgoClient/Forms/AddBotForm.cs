using AlgoClient.Classes;
using System;
using System.Windows.Forms;

namespace AlgoClient.Forms
{
    public partial class AddBotForm : Form
    {
        event EventHandler botCreated;
        public AddBotForm(EventHandler botCreated)
        {
            InitializeComponent();
            this.botCreated = botCreated;
        }

        private void AddBotForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            label9.Visible = false;
            comboBox2.Visible = false;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void AddBotButton_Click(object sender, EventArgs e)
        {
            Bot bot = new Bot();
            bool isValid = true;

            foreach (Control control in panel1.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if(!string.IsNullOrWhiteSpace(control.Text))
                    {
                        bot.AddAttribute((string)control.Tag, control.Text);
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

                if (control.GetType() == typeof(DateTimePicker))
                {                                     
                        DateTimePicker timePicker = (DateTimePicker)control;
                        bot.AddTimingAttribute(timePicker.Tag.ToString(), timePicker.Value.ToString());                 
                }

                if(control.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)control;
                    if(comboBox.Visible && comboBox.Tag.ToString().StartsWith("TIMING"))
                    {
                        bot.AddTimingAttribute(comboBox.Tag.ToString(), comboBox.SelectedIndex.ToString());
                    }
                    else
                    {
                        string value = comboBox.SelectedItem.Equals(">") ? "True" : "False";
                        bot.AddAttribute(comboBox.Tag.ToString(), value);
                    }
                }
            }
            if (isValid)
            {
                if(bot.Deploy())
                {
                    botCreated.Invoke(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show($"Error creating {bot.BotAttributes["NAME"]} bot!");
                }
            }
        }      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem?.ToString() == "weekly")
            {
                comboBox2.Visible = true;
                label9.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label9.Visible = false;
            }
        }
    }
}
