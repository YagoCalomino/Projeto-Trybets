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
    .Select(m => new MatchDTOResponse
    {
        MatchId = m.MatchId,
        MatchDate = m.MatchDate,
        MatchTeamAId = m.MatchTeamAId,
        MatchTeamBId = m.MatchTeamBId,
        TeamAName = m.MatchTeamA!.TeamName,
        TeamBName = m.MatchTeamB!.TeamName,
        MatchTeamAOdds = Math.Round((double)(m.MatchTeamAValue + m.MatchTeamBValue) / (double)m.MatchTeamAValue, 2).ToString("###.##"),
        MatchTeamBOdds = Math.Round((double)(m.MatchTeamAValue + m.MatchTeamBValue) / (double)m.MatchTeamBValue, 2).ToString("###.##"),
        MatchFinished = m.MatchFinished,
        MatchWinnerId = m.MatchWinnerId
    }).ToList();

    }
}