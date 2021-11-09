namespace Memorize
{
    partial class Memorize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memorize));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ForumMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GameTab = new System.Windows.Forms.TabPage();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.ListBox();
            this.LoginInfoText = new System.Windows.Forms.Label();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordBoxLG = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameBoxLG = new System.Windows.Forms.TextBox();
            this.PasswordLabelLG = new System.Windows.Forms.Label();
            this.UsernameLabelLG = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.CreateUserText = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.PasswordBoxCR = new System.Windows.Forms.TextBox();
            this.UsernameBoxCR = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PasswordLabelCR = new System.Windows.Forms.Label();
            this.UsernameLabelCR = new System.Windows.Forms.Label();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.MemorizeTab = new System.Windows.Forms.TabControl();
            this.HomeLoggedInTab = new System.Windows.Forms.TabPage();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.YouAreLoggInLabel = new System.Windows.Forms.Label();
            this.HighscoresTab = new System.Windows.Forms.TabPage();
            this.HighscoresBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.GameTab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MemorizeTab.SuspendLayout();
            this.HomeLoggedInTab.SuspendLayout();
            this.HighscoresTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitMenu,
            this.ForumMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GitMenu
            // 
            this.GitMenu.Name = "GitMenu";
            this.GitMenu.Size = new System.Drawing.Size(50, 29);
            this.GitMenu.Text = "Git";
            this.GitMenu.Click += new System.EventHandler(this.GitMenu_Click);
            // 
            // ForumMenu
            // 
            this.ForumMenu.Name = "ForumMenu";
            this.ForumMenu.Size = new System.Drawing.Size(80, 29);
            this.ForumMenu.Text = "Forum";
            this.ForumMenu.Click += new System.EventHandler(this.ForumMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 29);
            this.HelpMenu.Text = "Help";
            this.HelpMenu.Click += new System.EventHandler(this.HelpMenu_Click);
            // 
            // GameTab
            // 
            this.GameTab.Controls.Add(this.StartGameButton);
            this.GameTab.Controls.Add(this.games);
            this.GameTab.Controls.Add(this.LoginInfoText);
            this.GameTab.Location = new System.Drawing.Point(4, 34);
            this.GameTab.Name = "GameTab";
            this.GameTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameTab.Size = new System.Drawing.Size(551, 559);
            this.GameTab.TabIndex = 1;
            this.GameTab.Text = "Game";
            this.GameTab.UseVisualStyleBackColor = true;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(3, 443);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(527, 75);
            this.StartGameButton.TabIndex = 3;
            this.StartGameButton.Text = "Start Game!";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // games
            // 
            this.games.FormattingEnabled = true;
            this.games.ItemHeight = 25;
            this.games.Location = new System.Drawing.Point(6, 6);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(527, 429);
            this.games.TabIndex = 2;
            // 
            // LoginInfoText
            // 
            this.LoginInfoText.AutoSize = true;
            this.LoginInfoText.Location = new System.Drawing.Point(6, 521);
            this.LoginInfoText.Name = "LoginInfoText";
            this.LoginInfoText.Size = new System.Drawing.Size(527, 25);
            this.LoginInfoText.TabIndex = 1;
            this.LoginInfoText.Text = "Note: a player must first login before being able to select a game\r\n";
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.panel2);
            this.HomeTab.Controls.Add(this.OrLabel);
            this.HomeTab.Controls.Add(this.CreateUserText);
            this.HomeTab.Controls.Add(this.LoginText);
            this.HomeTab.Controls.Add(this.panel1);
            this.HomeTab.Controls.Add(this.WelcomeText);
            this.HomeTab.Location = new System.Drawing.Point(4, 34);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(551, 559);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PasswordBoxLG);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Controls.Add(this.UsernameBoxLG);
            this.panel2.Controls.Add(this.PasswordLabelLG);
            this.panel2.Controls.Add(this.UsernameLabelLG);
            this.panel2.Location = new System.Drawing.Point(19, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 109);
            this.panel2.TabIndex = 5;
            // 
            // PasswordBoxLG
            // 
            this.PasswordBoxLG.Location = new System.Drawing.Point(104, 68);
            this.PasswordBoxLG.Name = "PasswordBoxLG";
            this.PasswordBoxLG.PlaceholderText = "****";
            this.PasswordBoxLG.Size = new System.Drawing.Size(179, 31);
            this.PasswordBoxLG.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(324, 16);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(138, 83);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameBoxLG
            // 
            this.UsernameBoxLG.Location = new System.Drawing.Point(104, 16);
            this.UsernameBoxLG.Name = "UsernameBoxLG";
            this.UsernameBoxLG.PlaceholderText = "A unique username...";
            this.UsernameBoxLG.Size = new System.Drawing.Size(179, 31);
            this.UsernameBoxLG.TabIndex = 2;
            // 
            // PasswordLabelLG
            // 
            this.PasswordLabelLG.AutoSize = true;
            this.PasswordLabelLG.Location = new System.Drawing.Point(3, 68);
            this.PasswordLabelLG.Name = "PasswordLabelLG";
            this.PasswordLabelLG.Size = new System.Drawing.Size(91, 25);
            this.PasswordLabelLG.TabIndex = 1;
            this.PasswordLabelLG.Text = "Password:";
            // 
            // UsernameLabelLG
            // 
            this.UsernameLabelLG.AutoSize = true;
            this.UsernameLabelLG.Location = new System.Drawing.Point(3, 16);
            this.UsernameLabelLG.Name = "UsernameLabelLG";
            this.UsernameLabelLG.Size = new System.Drawing.Size(95, 25);
            this.UsernameLabelLG.TabIndex = 0;
            this.UsernameLabelLG.Text = "Username:";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Location = new System.Drawing.Point(265, 271);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(37, 25);
            this.OrLabel.TabIndex = 4;
            this.OrLabel.Text = "OR";
            // 
            // CreateUserText
            // 
            this.CreateUserText.AutoSize = true;
            this.CreateUserText.Location = new System.Drawing.Point(19, 302);
            this.CreateUserText.Name = "CreateUserText";
            this.CreateUserText.Size = new System.Drawing.Size(137, 25);
            this.CreateUserText.TabIndex = 3;
            this.CreateUserText.Text = "Create new user";
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(19, 111);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(56, 25);
            this.LoginText.TabIndex = 2;
            this.LoginText.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.CountryBox);
            this.panel1.Controls.Add(this.PasswordBoxCR);
            this.panel1.Controls.Add(this.UsernameBoxCR);
            this.panel1.Controls.Add(this.CountryLabel);
            this.panel1.Controls.Add(this.PasswordLabelCR);
            this.panel1.Controls.Add(this.UsernameLabelCR);
            this.panel1.Location = new System.Drawing.Point(19, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 152);
            this.panel1.TabIndex = 1;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(324, 31);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(138, 83);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(104, 108);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.PlaceholderText = "Belgium";
            this.CountryBox.Size = new System.Drawing.Size(179, 31);
            this.CountryBox.TabIndex = 5;
            // 
            // PasswordBoxCR
            // 
            this.PasswordBoxCR.Location = new System.Drawing.Point(104, 60);
            this.PasswordBoxCR.Name = "PasswordBoxCR";
            this.PasswordBoxCR.PlaceholderText = "ai3net";
            this.PasswordBoxCR.Size = new System.Drawing.Size(179, 31);
            this.PasswordBoxCR.TabIndex = 4;
            // 
            // UsernameBoxCR
            // 
            this.UsernameBoxCR.Location = new System.Drawing.Point(104, 14);
            this.UsernameBoxCR.Name = "UsernameBoxCR";
            this.UsernameBoxCR.PlaceholderText = "squidPlayer";
            this.UsernameBoxCR.Size = new System.Drawing.Size(179, 31);
            this.UsernameBoxCR.TabIndex = 3;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(3, 108);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(79, 25);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // PasswordLabelCR
            // 
            this.PasswordLabelCR.AutoSize = true;
            this.PasswordLabelCR.Location = new System.Drawing.Point(3, 60);
            this.PasswordLabelCR.Name = "PasswordLabelCR";
            this.PasswordLabelCR.Size = new System.Drawing.Size(91, 25);
            this.PasswordLabelCR.TabIndex = 1;
            this.PasswordLabelCR.Text = "Password:";
            // 
            // UsernameLabelCR
            // 
            this.UsernameLabelCR.AutoSize = true;
            this.UsernameLabelCR.Location = new System.Drawing.Point(3, 14);
            this.UsernameLabelCR.Name = "UsernameLabelCR";
            this.UsernameLabelCR.Size = new System.Drawing.Size(95, 25);
            this.UsernameLabelCR.TabIndex = 0;
            this.UsernameLabelCR.Text = "Username:";
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Location = new System.Drawing.Point(19, 35);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(462, 50);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Welcome fine payer, before we put your memory to test \r\nmake sure to login first!" +
    "";
            // 
            // MemorizeTab
            // 
            this.MemorizeTab.Controls.Add(this.HomeLoggedInTab);
            this.MemorizeTab.Controls.Add(this.HomeTab);
            this.MemorizeTab.Controls.Add(this.GameTab);
            this.MemorizeTab.Controls.Add(this.HighscoresTab);
            this.MemorizeTab.Location = new System.Drawing.Point(12, 36);
            this.MemorizeTab.Name = "MemorizeTab";
            this.MemorizeTab.SelectedIndex = 0;
            this.MemorizeTab.Size = new System.Drawing.Size(559, 597);
            this.MemorizeTab.TabIndex = 1;
            this.MemorizeTab.SelectedIndexChanged += new System.EventHandler(this.MemorizeTab_SelectedIndexChanged);
            // 
            // HomeLoggedInTab
            // 
            this.HomeLoggedInTab.Controls.Add(this.WelcomeLabel);
            this.HomeLoggedInTab.Controls.Add(this.YouAreLoggInLabel);
            this.HomeLoggedInTab.Location = new System.Drawing.Point(4, 34);
            this.HomeLoggedInTab.Name = "HomeLoggedInTab";
            this.HomeLoggedInTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeLoggedInTab.Size = new System.Drawing.Size(551, 559);
            this.HomeLoggedInTab.TabIndex = 3;
            this.HomeLoggedInTab.Text = "Home";
            this.HomeLoggedInTab.UseVisualStyleBackColor = true;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(167, 240);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(142, 25);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome Player!";
            // 
            // YouAreLoggInLabel
            // 
            this.YouAreLoggInLabel.AutoSize = true;
            this.YouAreLoggInLabel.Location = new System.Drawing.Point(22, 514);
            this.YouAreLoggInLabel.Name = "YouAreLoggInLabel";
            this.YouAreLoggInLabel.Size = new System.Drawing.Size(501, 25);
            this.YouAreLoggInLabel.TabIndex = 0;
            this.YouAreLoggInLabel.Text = "You are now logged in feel free to select a game and have fun";
            // 
            // HighscoresTab
            // 
            this.HighscoresTab.Controls.Add(this.HighscoresBox);
            this.HighscoresTab.Location = new System.Drawing.Point(4, 34);
            this.HighscoresTab.Name = "HighscoresTab";
            this.HighscoresTab.Padding = new System.Windows.Forms.Padding(3);
            this.HighscoresTab.Size = new System.Drawing.Size(551, 559);
            this.HighscoresTab.TabIndex = 2;
            this.HighscoresTab.Text = "Highscores";
            this.HighscoresTab.UseVisualStyleBackColor = true;
            // 
            // HighscoresBox
            // 
            this.HighscoresBox.AccessibleName = "Highscores";
            this.HighscoresBox.FormattingEnabled = true;
            this.HighscoresBox.ItemHeight = 25;
            this.HighscoresBox.Location = new System.Drawing.Point(0, 16);
            this.HighscoresBox.Name = "HighscoresBox";
            this.HighscoresBox.Size = new System.Drawing.Size(529, 529);
            this.HighscoresBox.TabIndex = 0;
            // 
            // Memorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 640);
            this.Controls.Add(this.MemorizeTab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Memorize";
            this.Text = "Memorize";
            this.Load += new System.EventHandler(this.Memorize_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GameTab.ResumeLayout(false);
            this.GameTab.PerformLayout();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MemorizeTab.ResumeLayout(false);
            this.HomeLoggedInTab.ResumeLayout(false);
            this.HomeLoggedInTab.PerformLayout();
            this.HighscoresTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GitMenu;
        private System.Windows.Forms.ToolStripMenuItem ForumMenu;
        private System.Windows.Forms.TabPage GameTab;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabControl MemorizeTab;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoginInfoText;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Label CreateUserText;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox PasswordBoxCR;
        private System.Windows.Forms.TextBox UsernameBoxCR;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PasswordLabelCR;
        private System.Windows.Forms.Label UsernameLabelCR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PasswordLabelLG;
        private System.Windows.Forms.Label UsernameLabelLG;
        private System.Windows.Forms.TextBox PasswordBoxLG;
        private System.Windows.Forms.TextBox UsernameBoxLG;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TabPage HighscoresTab;
        private System.Windows.Forms.TabPage HomeLoggedInTab;
        private System.Windows.Forms.Label YouAreLoggInLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ListBox HighscoresBox;
        private System.Windows.Forms.ListBox games;
        private System.Windows.Forms.Button StartGameButton;
    }
}

