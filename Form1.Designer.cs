namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            piratingAlarm = new Label();
            numberOfGames = new Label();
            pirateButton = new Button();
            SuspendLayout();
            // 
            // piratingAlarm
            // 
            piratingAlarm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            piratingAlarm.BackColor = Color.Transparent;
            piratingAlarm.Font = new Font("Courier New", 21F, FontStyle.Regular, GraphicsUnit.Point);
            piratingAlarm.Location = new Point(12, 298);
            piratingAlarm.Name = "piratingAlarm";
            piratingAlarm.Size = new Size(920, 117);
            piratingAlarm.TabIndex = 1;
            piratingAlarm.Text = "label1";
            piratingAlarm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberOfGames
            // 
            numberOfGames.BackColor = Color.Transparent;
            numberOfGames.Font = new Font("Courier New", 34F, FontStyle.Bold, GraphicsUnit.Point);
            numberOfGames.Location = new Point(12, 155);
            numberOfGames.Name = "numberOfGames";
            numberOfGames.Size = new Size(920, 143);
            numberOfGames.TabIndex = 2;
            numberOfGames.Text = "label1";
            numberOfGames.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pirateButton
            // 
            pirateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pirateButton.BackColor = Color.FromArgb(138, 169, 200);
            pirateButton.FlatAppearance.BorderSize = 0;
            pirateButton.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pirateButton.Location = new Point(336, 411);
            pirateButton.Name = "pirateButton";
            pirateButton.Size = new Size(272, 89);
            pirateButton.TabIndex = 3;
            pirateButton.Text = "BAIXAR AGORA";
            pirateButton.UseVisualStyleBackColor = false;
            pirateButton.Click += pirateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(944, 601);
            Controls.Add(pirateButton);
            Controls.Add(numberOfGames);
            Controls.Add(piratingAlarm);
            MaximumSize = new Size(960, 640);
            MinimumSize = new Size(600, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pirateando a Neentendo Simulator";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label piratingAlarm;
        private Label numberOfGames;
        private Button pirateButton;
    }
}