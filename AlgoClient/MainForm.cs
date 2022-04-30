using AlgoClient.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AlgoClient
{    
    public partial class MainForm : Form
    {
        public event EventHandler BotCreated;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BotCreated += MainForm_BotCreated; ;
        }

        private void MainForm_BotCreated(object sender, EventArgs e)
        {
            LoadBots();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(MenuPanel);
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TitlePanel.BackColor = color;
                    LogoPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton(Panel panel)
        {
            foreach (Control previousBtn in panel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                if (previousBtn.GetType() == typeof(Panel))
                {
                    DisableButton((Panel)previousBtn);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.Load += ThemeColor.LoadTheme;
            ActivateButton(btnSender);
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.WorkspacePanel.Controls.Add(childForm);
            this.WorkspacePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;
        }

        private void AddBotButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddBotForm(BotCreated), sender);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form(), sender);
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBots();
        }

        private void LoadBots()
        {
            string[] files = System.IO.Directory.GetFiles("Bots");
            BotsListPanel.RightToLeft = RightToLeft.Yes;
            BotsListPanel.Controls.Clear();
            foreach (string fileName in files)
            {
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Height = 60;
                btn.Dock = DockStyle.Top;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = fileName.Split('\\')[1]
                                   .Split('.')[0];
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.Gainsboro;
                btn.RightToLeft = RightToLeft.No;

                BotsListPanel.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpenChildForm(new Forms.BotForm(Bot.LoadBotFromFile($@"Bots\{btn.Text}.txt")), sender);
        }

        protected virtual void OnBotCreated(EventArgs e)
        {
            EventHandler handler = BotCreated;
            handler?.Invoke(this, e);
        }

      
    }
}
