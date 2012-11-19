/*
 * This file is part of DTWrapper.
 * 
 * DTWrapper is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * DTWrapper is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with DTWrapper. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DTWrapper.POCO;
using DTWrapper.Helpers;

namespace DTWrapper.BLL
{
    /// <summary>
    /// Manages the games database
    /// </summary>
    public class GamesManager : Manager
    {
        public GamesManager() : base() { }

        /// <summary>
        /// Add a game to the database
        /// </summary>
        /// <param name="game">The game to add</param>
        /// <returns>true on success</returns>
        public bool AddGame(Game game)
        {
            using (context = new gamesEntities(conn))
            {
                try
                {
                    context.Games.AddObject(game);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                    return false;
                }
            }
        }

        /// <summary>
        /// Removes a game from the database
        /// </summary>
        /// <param name="game">The game to remove</param>
        /// <returns>true on success</returns>
        public bool DelGame(Game game)
        {
            using (context = new gamesEntities(conn))
            {
                try
                {
                    context.Games.Attach(game);
                    context.Games.DeleteObject(game);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                    return false;
                }
            }
        }

        /// <summary>
        /// Get a game from an ID
        /// </summary>
        /// <param name="id">ID of the game</param>
        /// <returns>The game</returns>
        public Game GetGame(long id)
        {
            using (context = new gamesEntities(conn))
            {
                return (from g in context.Games where g.ID.Equals(id) select g).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get a game from a name
        /// </summary>
        /// <param name="name">Name of the game</param>
        /// <returns>The game</returns>
        public Game GetGame(string name)
        {
            using (context = new gamesEntities(conn))
            {
                return (from g in context.Games where g.Name.Equals(name) select g).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get all games in database
        /// </summary>
        /// <returns>All games</returns>
        public List<Game> GetGames()
        {
            using (context = new gamesEntities(conn))
            {
                return (from g in context.Games select g).ToList();
            }
        }

        /// <summary>
        /// Get a game ID from his name
        /// </summary>
        /// <param name="name">Name of the game</param>
        /// <returns>ID of the game</returns>
        public long GetGameId(string name)
        {
            using (context = new gamesEntities(conn))
            {
                Game game = (from g in context.Games where g.Name.Equals(name) select g).FirstOrDefault();

                return (game == null) ? -1 : game.ID;
            }
        }

        /// <summary>
        /// Get the count of games in database
        /// </summary>
        /// <returns>The number of games</returns>
        public int GetNbGames()
        {
            using (context = new gamesEntities(conn))
            {
                return context.Games.Count();
            }
        }

        /// <summary>
        /// Updates a game in the database
        /// </summary>
        /// <param name="g">The game with new values</param>
        /// <returns>true on success</returns>
        public bool UpdateGame(Game g)
        {
            using (context = new gamesEntities(conn))
            {
                try
                {
                    context.Games.Attach(g);
                    context.ObjectStateManager.ChangeObjectState(g, EntityState.Modified);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                    return false;
                }
            }
        }
    }
}
