using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WORKS_T1.Models;

public class NotePagePiece
{
    public int Id { get; set; }

    [Required]
    public int PageId { get; set; }

    [Required]
    public int Order { get; set; }

    [Required]
    public string? Value { get; set; }

    [Required]
    public int type { get; set; }
}