using TryBets.Matches.DTO;

namespace TryBets.Matches.Repository;

public class MatchRepository : IMatchRepository
{
    protected readonly ITryBetsContext _context;
    public MatchRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public IEnumerable<MatchDTOResponse> Get(bool matchFinished)
    {
return _context.Matches
                .Where(m => m.MatchFinished == matchFinished)
                .OrderBy(m => m.MatchId)
                .Select(m => new MatchDTOResponse{
                    MatchId = m.MatchId,
                    MatchDate = m.MatchDate,
                    MatchTeamAId = m.MatchTeamAId,
                    MatchTeamBId = m.MatchTeamBId,
                    TeamAName = m.MatchTeamA.TeamName,
                    TeamBName = m.MatchTeamB.TeamName,
                    MatchTeamAOdds = string.Format("{0:0.00}", Math.Round((m.MatchTeamAValue + m.MatchTeamBValue) / m.MatchTeamAValue, 2)),
                    MatchTeamBOdds = string.Format("{0:0.00}", Math.Round((m.MatchTeamAValue + m.MatchTeamBValue) / m.MatchTeamBValue, 2)),
                    MatchFinished = m.MatchFinished,
                    MatchWinnerId = m.MatchWinnerId
                }).ToList();
    }
}