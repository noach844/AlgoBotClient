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
            
            }
            if (isValid)
            {
                bot.CreateConfigFile();
                botCreated.Invoke(sender, new EventArgs());
            }
        }
    }
}
