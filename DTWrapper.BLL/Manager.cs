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
using System.Data.Entity;
using System.Linq;
using System.Text;
using DTWrapper.POCO;
using DTWrapper.Helpers;

namespace DTWrapper.BLL
{
    /// <summary>
    /// Parent of all managers
    /// </summary>
    public abstract class Manager
    {
        protected gamesEntities context;
        protected string conn;

        public Manager()
        {
            conn = ConfigurationManager.ConnectionStrings["gamesEntities"].ToString();
        }
    }
}
