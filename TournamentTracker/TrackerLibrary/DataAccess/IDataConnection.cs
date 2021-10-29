using System;
using TrackerLibrary.models;
//using System.Data;
//using System.Data.Common;
//using System.Data.SQLite;
//using Mono.Data.SqliteClient;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);

        void UpdateMatchupModel(MatchupModel model);

        void CompleteTournament(MatchupModel model);

        List<TeamModel> GetTeam_All(); 
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
    }
}