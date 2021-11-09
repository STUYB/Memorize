using Memorize.Entities;
using Memorize.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Memorize
{
    public partial class Memorize : Form
    {
        // Repositories
        private PlayersRepository playersRepository { get; set; }
        private GamesRepository gamesRepository { get; set; }
        private HighscoresRepository highscoresRepository { get; set; }
        // Player & current Games in DB
        public Player Player { get; set; }
        public List<Game>? Games { get; set; }

        public Memorize()
        {
            InitializeComponent();
            playersRepository = new PlayersRepository();
            gamesRepository = new GamesRepository();
            highscoresRepository = new HighscoresRepository();
        }
        private void Memorize_Load(object sender, EventArgs e)
        {
            // Hide/Disable tab (only allow game selection to logged in players)
            MemorizeTab.TabPages.Remove(HomeLoggedInTab);
            MemorizeTab.TabPages[1].Enabled = false;
            // Load games
            Games = gamesRepository.GetAll();
            foreach (var game in Games)
            {
                games.Items.Add($"{game.Name}");
            };
        }

        // Menu
        private void GitMenu_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/STUYB";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        private void ForumMenu_Click(object sender, EventArgs e)
        {
            var uri = "https://forums.pcgamer.com/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        private void HelpMenu_Click(object sender, EventArgs e)
        {
            var uri = "https://c0.wallpaperflare.com/preview/192/962/573/help-hand-god-fantasy-thumbnail.jpg";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        // Log In or Create Player
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBoxLG.Text;
            string password = PasswordBoxLG.Text;
            if (username != string.Empty && password != string.Empty)
            {
                Player player = new Player();
                player.Username = username;
                player.Password = password;
                List<Player> players = playersRepository.GetAll();
                Player? foundPlayer = players.Find(oPlayer => oPlayer.Username == username);
                if (foundPlayer == null) 
                {
                    MessageBox.Show("Player with following username does not exist");
                } else
                {
                    if (player.Password == foundPlayer.Password)
                    {
                        MessageBox.Show("You logged in successfully!");
                        LoginSuccessCallback(player);
                    } else {
                        MessageBox.Show("Wrong Password");
                    }
                }
            } else
            {
                MessageBox.Show("Username and Password are required");
            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBoxCR.Text;
            string password = PasswordBoxCR.Text;
            string country = CountryBox.Text;
            if (username != string.Empty && password != string.Empty && country != string.Empty)
            {
                Player player = new Player();
                player.Username = username;
                player.Password = password;
                player.Country = country;
                List<Player> players = playersRepository.GetAll();
                Player? foundPlayer = players.Find(oPlayer => oPlayer.Username == username);
                if (foundPlayer != null)
                {
                    MessageBox.Show("Player with following username already exist");
                }
                else
                {
                    playersRepository.Insert(player);
                    MessageBox.Show("Player created, you are now logged in!");
                    LoginSuccessCallback(player);
                }
            }
            else
            {
                MessageBox.Show("Username, Password and Country are required");
            }
        }
        public void LoginSuccessCallback(Player player) {
            MemorizeTab.TabPages[1].Enabled = true;
            MemorizeTab.Enabled = true;
            MemorizeTab.TabPages.Remove(HomeTab);
            MemorizeTab.TabPages.Insert(0, HomeLoggedInTab);
            MemorizeTab.SelectedTab = HomeLoggedInTab;
            LoginInfoText.Visible = false;
            WelcomeLabel.Text = $"Welcome {player.Username}!";
            Player = player;
        }

        // Select and start game
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = games.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a game first");
            }
            else
            {
                Game selectedGame = Games[selectedIndex];
                Forms.Memorize newGame = new Forms.Memorize(selectedGame);
                newGame.Player = Player;
                newGame.Show();
            }
        }

        // Highscores, ranking is calculated in function of nr of games won
        private void MemorizeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl.SelectedTab == HighscoresTab)
            {
                List<Highscore> highscores = highscoresRepository.GetAll();
                List<Player> players = new List<Player>();
                HighscoresBox.Items.Clear();
                foreach (var highscore in highscores)
                {
                    Player currentPlayer = new Player();
                    currentPlayer.Username = highscore.Username;
                    currentPlayer.GamesWon = highscores.Where(score => score.Username == currentPlayer.Username).ToArray().Length;
                    int index = players.FindIndex(p => p.Username == currentPlayer.Username);
                    if (index < 0)
                    {
                        players.Add(currentPlayer);
                    }
                }
                // Brute Force Highscore calculation and display
                int min = players.Min(player => player.GamesWon);
                int max = players.Max(player => player.GamesWon);
                int j = 1;
                for (int i = max; i >= min; i--)
                {
                    bool header = false;
                    bool incr = false;
                    string playersString = "Players: ";
                    List<Player> tempPlayers = players.Where(player => player.GamesWon == i).ToList();
                    if (tempPlayers.Count > 0)
                    {
                        foreach (var player in tempPlayers)
                        {
                            if (!header)
                            {
                                HighscoresBox.Items.Add($"#{j} - Games Won: {player.GamesWon}");
                                header = true;
                            }
                            playersString = playersString + $"{player.Username}, ";
                            incr = true;
                        }
                        playersString = playersString.Remove(playersString.Length - 2);
                        HighscoresBox.Items.Add(playersString);
                        if (incr)
                        {
                            j++;
                        }
                    }
                }
            }
        }
    }
}
