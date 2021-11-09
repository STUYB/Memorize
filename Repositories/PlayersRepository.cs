using Memorize.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Repositories
{
    public class PlayersRepository : BaseRepository<Player>
    {
        public override List<Player> GetAll()
        {
            List<Player> players = new List<Player>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [id], [username], [password], [country] FROM [Players]";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var player = MapPlayerFromReader(reader);
                players.Add(player);
            }
            return players;
        }
        public override Player Insert(Player player)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO [Players] (username, password, country) VALUES (@Username, @Password, @Country); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Username", player.Username);
            command.Parameters.AddWithValue("@Password", player.Password);
            command.Parameters.AddWithValue("@Country", player.Country);
            using var reader = command.ExecuteReader();
            reader.Read();
            player.Id = (int)reader.GetDecimal(0);
            return player;
        }
        public override void Update(Player player)
        {
            throw new NotImplementedException();
        }
        // Helpers
        private Player MapPlayerFromReader(SqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var username = reader.GetString(1);
            var password = reader.GetString(2);
            var country = reader.GetString(3);
            Player player = new Player();
            player.Id = id;
            player.Username = username;
            player.Password = password;
            player.Country = country;
            return player;
        }
    }
}
