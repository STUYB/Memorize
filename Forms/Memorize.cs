using Memorize.Entities;
using Memorize.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize.Forms
{
    public partial class Memorize : Form
    {
        // Repositories
        private HighscoresRepository highscoresRepository { get; set; }
        // Game & Player
        public Entities.Game Game { get; set; }
        public Player Player { get; set; }
        // Project settings
        public string ProjectPath { get; set; }
        public string ThemePath { get; set; }
        // Game properties
        public List<PictureBox> Cards { get; set; }
        public List<string> CardsValue { get; set; }
        public List<bool> CardsSolved { get; set; }
        public int GameClicksCount { get; set; } = 0;
        public int CardsClicked { get; set; } = 1;
        public PictureBox FirstCard { get; set; }
        public PictureBox SecondCard { get; set; }

        public Memorize(Game game)
        {
            InitializeComponent();
            highscoresRepository = new HighscoresRepository();
            this.Game = game;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            SetProjectPath();
            SetThemePath();
            SetGameSize();
            InitializeCards();
            ShuffleCards();
            SetCardsClickEvent();
            InitializeGame();
        }

        // Project settings
        public void SetProjectPath() 
        {
            ProjectPath = Directory.GetCurrentDirectory();
            ProjectPath = ProjectPath.Replace(@"bin\Debug\net6.0-windows", "");
        }
        public void SetThemePath()
        {
            ThemePath = $@"Resources\Images\Themes\{Game.Theme}";
            ThemePath = $@"{ProjectPath}{ThemePath}";
        }

        // Game Size
        public void SetGameSize()
        {
            string size = Game.Size;
            List<PictureBox> controls = GetCardsControls();
            foreach (var control in controls)
            {
                if (control.AccessibleName != null && control.AccessibleName.Contains(size))
                {
                    RemoveCardControl(control);
                }
            }
            switch (size)
            {
                case "SMALL":
                    this.Size = new Size(620, 550);
                    break;
                case "MEDIUM":
                    this.Size = new Size(620, this.Size.Height);
                    break;
                default:
                    // DO nothing, keep as is
                    break;
            }
        }
        public List<PictureBox> GetCardsControls()
        {
            List<PictureBox> controls = Controls.Cast<Control>()
                .Where(control => control is PictureBox)
                .Select(control => (PictureBox)control)
                .ToList();
            return controls;
        }
        public void RemoveCardControl(PictureBox control)
        {
            Controls.Remove(control);
        }

        // Cards initialization
        public void InitializeCards() 
        {
            Cards = GetCardsControls();
            foreach (var control in Cards)
            {
                string starPath = $@"{ThemePath}\0.png";
                SetImage(control, starPath);
            }
        }
        public void ShuffleCards()
        {
            int size = Cards.Count;
            // 0. Construct solved cards array
            CardsSolved = new List<bool>();
            // 1. Construct array of integers (and init solved array)
            List<int> indexes = new List<int>();
            int cnt = 1;
            for (int i = 0; i < size; i++)
            {
                cnt = cnt > (size / 2) ? 1 : cnt;
                indexes.Add(cnt);
                cnt++;
                CardsSolved.Add(false); // Set all to false
            }
            // 2. Shuffle (pick random int and swap)
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                int j = rand.Next(i, size);
                int temp = indexes[i];
                indexes[i] = indexes[j];
                indexes[j] = temp;
            }
            CardsValue = new List<string>();
            for (int i = 0; i < size; i++)
            {
                CardsValue.Add($@"{ThemePath}\{indexes[i]}.png");
            }
        }
        public void SetCardsClickEvent()
        {
            foreach (var card in Cards)
            {
                card.Click += new EventHandler(CardClicked);
            }
        }
        // Main Game Event (engine of the game)
        private void CardClicked(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            int index = Cards.IndexOf(card);
            string path = $@"{CardsValue[index]}";
            if (CardsClicked > 1)
            {
                if (FirstCard != Cards[index])
                {
                    SecondCard = Cards[index];
                    SetImage(card, path);
                    CardsClicked = 1;
                    IncrementClickCount();
                    CheckCardsAsync();
                }
            }
            else
            {
                FirstCard = Cards[index];
                SetImage(card, path);
                CardsClicked = CardsClicked + 1;
                IncrementClickCount();
            }
        }
        public void IncrementClickCount()
        {
            GameClicksCount = GameClicksCount + 1;
            ClicksCount.Text = GameClicksCount.ToString();
        }
        public async Task CheckCardsAsync()
        {
            int firstIndex = Cards.IndexOf(FirstCard);
            int secondIndex = Cards.IndexOf(SecondCard);
            if (CardsValue[firstIndex] == CardsValue[secondIndex])
            {
                CardsSolved[firstIndex] = true;
                CardsSolved[secondIndex] = true;
                RemoveSolvedCards(); // Disable + remove click event
                CheckGameSolved();
            }
            else 
            {
                EnableCards(false);
                await Wait();
                EnableCards(true);
                string starPath = $@"{ThemePath}\0.png";
                SetImage(FirstCard, starPath);
                SetImage(SecondCard, starPath);
            }
        }
        public void RemoveSolvedCards()
        {
            foreach (var card in Cards)
            {
                int index = Cards.IndexOf(card);
                if (CardsSolved[index])
                {
                    card.Enabled = false;
                    card.Click -= CardClicked;
                }
            }
        }
        public void EnableCards(bool value)
        {
            foreach (var card in Cards)
            {
                int index = Cards.IndexOf(card);
                if (!CardsSolved[index])
                {
                    card.Enabled = value;

                }
            }
        }
        public async Task Wait()
        {
            await Task.Delay(1500);
        }
        public void CheckGameSolved() 
        {
            int i = CardsSolved.IndexOf(false);
            if (i == -1)
            {
                DisableTimer();
                MessageBox.Show("Congratulations!!! You solved the game!");
                SaveScore();
                this.Close();
            }
        }
        public void InitializeGame()
        {
            if (Game.Timer > 0)
            {
                TimerCount.Text = Game.Timer.ToString();
                timer1.Interval = 1000;
                timer1.Start();
                timer1.Tick += TimerTick;
            }
            else
            {
                TimeLabel.Visible = false;
                TimerCount.Visible = false;
            }
        }

        public void TimerTick(object sender, EventArgs e)
        {
            int timeLeft = Int32.Parse(TimerCount.Text) - 1;
            TimerCount.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                DisableTimer();
                MessageBox.Show("Times up!!! You can always try again!");
                this.Close();
            }
        }
        public void DisableTimer()
        {
            if(Game.Timer > 0)
            {
                timer1.Stop();
                timer1.Tick -= TimerTick;
            }
        }
        // Helpers
        public void SetImage(PictureBox control, string path)
        {
            PictureBox pictureBox = control;
            pictureBox.Image = Image.FromFile(path);
        }
        public void SaveScore()
        {
            List<Highscore> highscores = highscoresRepository.GetAll();
            Highscore highscore = new Highscore();
            highscore.Username = Player.Username;
            highscore.Game = Game.Name;
            highscore.Clicks = GameClicksCount;
            int index = highscores.FindIndex(highscore =>
            highscore.Game == Game.Name && highscore.Username == Player.Username);
            if (index < 0)
            {
                highscoresRepository.Insert(highscore);
            }
            else if (highscores[index].Clicks > GameClicksCount)
            {
                highscore.Id = highscores[index].Id;
                highscoresRepository.Update(highscore);
            }
        }
    }
}
