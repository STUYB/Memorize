using Memorize.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Repositories
{
    public class GamesRepository : BaseRepository<Game>
    {
        public override List<Game> GetAll()
        {
            List<Game> games = new List<Game>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [id], [name], [size], [timer], [theme] FROM [Games]";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var game = MapGameFromReader(reader);
                games.Add(game);
            }
            return games;
        }
        public override Game Insert(Game entity)
        {
            throw new NotImplementedException();
        }
        public override void Update(Game entity)
        {
            throw new NotImplementedException();
        }
        // Helpers
        private Game MapGameFromReader(SqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var name = reader.GetString(1);
            var size = reader.GetString(2);
            var timer = reader.GetInt32(3);
            var theme = reader.GetString(4);
            Game game = new Game();
            game.Id = id;
            game.Name = name;
            game.Size = size;
            game.Timer = timer;
            game.Theme = theme;
            return game;
        }
    }
}
