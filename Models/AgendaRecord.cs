using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WORKS_T1.Models;


public class AgendaRecord
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public Int64? startDate { get; set; }
    public Int64? endDate { get; set; }
    public int notePageCode { get; set; } = -1; // is for linking a page to the record for noting purposes
}