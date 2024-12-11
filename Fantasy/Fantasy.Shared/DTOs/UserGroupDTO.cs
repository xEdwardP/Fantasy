using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.DTOs;

public class UserGroupDTO
{
    public int Id { get; set; }

    [MaxLength(450)]
    public string UserId { get; set; } = null!;

    public int GroupId { get; set; }

    public bool IsActive { get; set; }
}