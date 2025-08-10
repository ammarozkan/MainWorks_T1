using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WORKS_T1.Models;

namespace WORKS_T1.Data
{
    public class WORKS_T1_Context : DbContext
    {
        public WORKS_T1_Context(DbContextOptions<WORKS_T1_Context> options)
            : base(options)
        {
        }

        public DbSet<WORKS_T1.Models.Project> Project { get; set; } = default!;
        public DbSet<WORKS_T1.Models.AgendaRecord> AgendaRecord { get; set; } = default!;

        public DbSet<WORKS_T1.Models.FileObject> FileObject { get; set; } = default!;

        public DbSet<WORKS_T1.Models.NotePage> NotePage { get; set; } = default!;
        public DbSet<WORKS_T1.Models.NotePagePiece> NotePagePiece { get; set; } = default!;
    }
}
