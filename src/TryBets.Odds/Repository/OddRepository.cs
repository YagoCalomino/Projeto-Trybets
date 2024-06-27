using TryBets.Odds.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;

namespace TryBets.Odds.Repository;

public class OddRepository : IOddRepository
{
    protected readonly ITryBetsContext _context;
    public OddRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public Match Patch(int MatchId, int TeamId, string BetValue)
    {
        string betValueStr = BetValue.Replace(',', '.');
        decimal betValueDec = decimal.Parse(betValueStr, CultureInfo.InvariantCulture);

        var selectedMatch = _context.Matches.Find(MatchId) ?? throw new Exception("Match not found");

        if (selectedMatch.MatchTeamAId == TeamId)
        {
            selectedMatch.MatchTeamAValue += betValueDec;
        }
        else if (selectedMatch.MatchTeamBId == TeamId)
        {
            selectedMatch.MatchTeamBValue += betValueDec;
        }
        else
        {
            throw new Exception("Team not found");
        }

        _context.SaveChanges();

        return selectedMatch;
    }
}