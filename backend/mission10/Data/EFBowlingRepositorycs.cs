
using Microsoft.AspNetCore.Mvc;

namespace mission10.Data
{
    public class EFBowlingRepositorycs : IBowlingRepository
    {
        private BowlingContext _context;
        public EFBowlingRepositorycs(BowlingContext temp) {
            _context = temp;
        }

        public IEnumerable<Bowlers> Bowlers => throw new NotImplementedException();

        public IEnumerable<Teams> Teams => throw new NotImplementedException();

        public IEnumerable<object> GetBowlers()
        {
            var bowlersAndTeams = from bowler in _context.Bowlers
                                  join team in _context.Teams
                                  on bowler.TeamID equals team.TeamID
                                  where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                                  select new
                                  {
                                      BowlerID = bowler.BowlerID,
                                      BowlerLastName = bowler.BowlerLastName,
                                      BowlerFirstName = bowler.BowlerFirstName,
                                      BowlerMiddleInit = bowler.BowlerMiddleInit,
                                      BowlerAddress = bowler.BowlerAddress,
                                      BowlerCity = bowler.BowlerCity,
                                      BowlerState = bowler.BowlerState,
                                      BowlerZip = bowler.BowlerZip,
                                      BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                      TeamName = team.TeamName
                                  };


            return bowlersAndTeams.ToList();
        }

    }
}
