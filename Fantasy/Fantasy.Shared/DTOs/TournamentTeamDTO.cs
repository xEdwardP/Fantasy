using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.DTOs;

public class TournamentTeamDTO
{
    public int Id { get; set; }

    public int TournamentId { get; set; }

    public int TeamId { get; set; }
}