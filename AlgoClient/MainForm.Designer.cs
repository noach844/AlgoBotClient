namespace AlgoClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BotsListPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBotButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.MaxButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WorkspacePanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.MenuPanel.Controls.Add(this.BotsListPanel);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.AddBotButton);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(220, 557);
            this.MenuPanel.TabIndex = 0;
            // 
            // BotsListPanel
            // 
            this.BotsListPanel.AutoScroll = true;
            this.BotsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotsListPanel.Location = new System.Drawing.Point(0, 220);
            this.BotsListPanel.Name = "BotsListPanel";
            this.BotsListPanel.Size = new System.Drawing.Size(220, 337);
            this.BotsListPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(220, 80);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlgoClient.Properties.Resources.Bot;
            this.pictureBox1.Location = new System.Drawing.Point(41, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bots";
            // 
            // AddBotButton
            // 
            this.AddBotButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBotButton.FlatAppearance.BorderSize = 0;
            this.AddBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBotButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddBotButton.Image = global::AlgoClient.Properties.Resources.AddIcon3;
            this.AddBotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBotButton.Location = new System.Drawing.Point(0, 80);
            this.AddBotButton.Name = "AddBotButton";
            this.AddBotButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.AddBotButton.Size = new System.Drawing.Size(220, 60);
            this.AddBotButton.TabIndex = 1;
            this.AddBotButton.Text = "Add Bot";
            this.AddBotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBotButton.UseVisualStyleBackColor = true;
            this.AddBotButton.Click += new System.EventHandler(this.AddBotButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(220, 80);
            this.LogoPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TitlePanel.Controls.Add(this.MaxButton);
            this.TitlePanel.Controls.Add(this.MinButton);
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(220, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(764, 80);
            this.TitlePanel.TabIndex = 1;
            this.TitlePanel.DoubleClick += new System.EventHandler(this.MaxButton_Click);
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.FlatAppearance.BorderSize = 0;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.MaxButton.Image = ((System.Drawing.Image)(resources.GetObject("MaxButton.Image")));
            this.MaxButton.Location = new System.Drawing.Point(695, 3);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(30, 30);
            this.MaxButton.TabIndex = 3;
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.MinButton.Image = global::AlgoClient.Properties.Resources.minmize;
            this.MinButton.Location = new System.Drawing.Point(659, 3);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(30, 30);
            this.MinButton.TabIndex = 2;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CloseButton.Image = global::AlgoClient.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(731, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(356, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(83, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Home";
            // 
            // WorkspacePanel
            // 
            this.WorkspacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkspacePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WorkspacePanel.Location = new System.Drawing.Point(220, 80);
            this.WorkspacePanel.Name = "WorkspacePanel";
            this.WorkspacePanel.Size = new System.Drawing.Size(764, 477);
            this.WorkspacePanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.WorkspacePanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button AddBotButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel WorkspacePanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BotsListPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

