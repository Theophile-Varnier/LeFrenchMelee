﻿using LeFrenchMelee.Data;
using LeFrenchMelee.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeFrenchMelee.Services
{
    public class TournamentService : AbstractService
    {
        public TournamentService(UnitOfWork unitOfWork)
            :base(unitOfWork)
        {

        }

        /// <summary>
        /// Inserts the specified tournament.
        /// </summary>
        /// <param name="tournament">The tournament.</param>
        /// <returns></returns>
        public Tournament Insert(Tournament tournament)
        {
            return UnitOfWork.TournamentProvider.Add(tournament);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Tournament GetById(int id)
        {
            return UnitOfWork.TournamentProvider.GetById(id);
        }

        public IEnumerable<Tournament> GetAll()
        {
            return UnitOfWork.TournamentProvider.GetAll().ToList();
        }
    }
}
