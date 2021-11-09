using Memorize.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Repositories
{
    public class HighscoresRepository : BaseRepository<Highscore>
    {
        public override List<Highscore> GetAll()
        {
            List<Highscore> highscores = new List<Highscore>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [id], [username], [game], [clicks] FROM [Highscores]";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var highscore = MapHighscoreFromReader(reader);
                highscores.Add(highscore);
            }
            return highscores;
        }
        public override Highscore Insert(Highscore highscore)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Highscores] (username, game, clicks) VALUES (@Username, @Game, @Clicks); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Username", highscore.Username);
            command.Parameters.AddWithValue("@Game", highscore.Game);
            command.Parameters.AddWithValue("@Clicks", highscore.Clicks);
            using var reader = command.ExecuteReader();
            reader.Read();
            highscore.Id = (int)reader.GetDecimal(0);
            return highscore;
        }
        public override void Update(Highscore highscore)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Highscores] SET [username] = @Username, [game] = @Game, [clicks] = @Clicks WHERE [id] = @ID ";
            command.Parameters.AddWithValue("@ID", highscore.Id);
            command.Parameters.AddWithValue("@Username", highscore.Username);
            command.Parameters.AddWithValue("@Game", highscore.Game);
            command.Parameters.AddWithValue("@Clicks", highscore.Clicks);
            command.ExecuteNonQuery();
        }

        // Helpers
        private Highscore MapHighscoreFromReader(SqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var username = reader.GetString(1);
            var game = reader.GetString(2);
            var clicks = reader.GetInt32(3);
            Highscore highscore = new Highscore();
            highscore.Id = id;
            highscore.Username = username;
            highscore.Game = game;
            highscore.Clicks = clicks;
            return highscore;
        }
    }
}
