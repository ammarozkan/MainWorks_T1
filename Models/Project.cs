using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WORKS_T1.Models;

public enum FocusType : int
{
    MONO = 0,
    POLY = 1
}

public class Project
{
    public int Id { get; set; }
    public string? ProjectName { get; set; }
    public bool isOnGoing { get; set; } = false;
    public Int64 lastAction { get; set; } = DateTime.Now.Ticks;
    public FocusType focusType { get; set; } = FocusType.MONO;

    public int? ActiveAgendaRecordId { get; set; } = null;

    public List<int> SeePermissions { get; set; } = new();
    public List<int> WritePermissions { get; set; } = new();

    public string CategoryName { get; set; } = "Nothing";
}