using Fantasy.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entites;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "Country", ResourceType = typeof(Literals))]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Name { get; set; } = null!;

    // Relacion de uno a muchos
    public ICollection<Team>? Teams { get; set; }

    // Propiedad de lectura
    public int TeamsCount => Teams == null ? 0 : Teams.Count;

    public ICollection<User>? Users { get; set; }
    public int UsersCount => Users == null ? 0 : Users.Count;
}