namespace AlgoClient.Forms
{
    partial class BotForm
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
            this.AttributesPanel = new System.Windows.Forms.Panel();
            this.BoxesPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.AttributesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttributesPanel
            // 
            this.AttributesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttributesPanel.Controls.Add(this.BoxesPanel);
            this.AttributesPanel.Controls.Add(this.LabelsPanel);
            this.AttributesPanel.Location = new System.Drawing.Point(238, 63);
            this.AttributesPanel.Name = "AttributesPanel";
            this.AttributesPanel.Size = new System.Drawing.Size(340, 274);
            this.AttributesPanel.TabIndex = 0;
            this.AttributesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AttributesPanel_Paint);
            // 
            // BoxesPanel
            // 
            this.BoxesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoxesPanel.Location = new System.Drawing.Point(170, 0);
            this.BoxesPanel.Name = "BoxesPanel";
            this.BoxesPanel.Size = new System.Drawing.Size(170, 274);
            this.BoxesPanel.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(481, 383);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(97, 35);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LabelsPanel
            // 
            this.LabelsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelsPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(170, 274);
            this.LabelsPanel.TabIndex = 1;
            // 
            // BotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AttributesPanel);
            this.Name = "BotForm";
            this.Text = "BotForm";
            this.Load += new System.EventHandler(this.BotForm_Load);
            this.AttributesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AttributesPanel;
        private System.Windows.Forms.Panel BoxesPanel;
        private System.Windows.Forms.Panel LabelsPanel;
        private System.Windows.Forms.Button UpdateButton;
    }
}