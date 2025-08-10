using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WORKS_T1.Models;



// UPDATE THE DATABASE

public class FileObject
{
    public int Id { get; set; }

    public bool isFolder { get; set; } = false;
    public string? Name { get; set; }

    public string? Path { get; set; } // paths are continuation. after the folder url
    public string? RealName { get; set; } // used to calculate the real path. contains the real name.
    public int BelongingFolderCode { get; set; } = -1;
    public long Size { get; set; } = 0;
}

// how do path calculate?
//
// sums all the parent RealNames. that is the real path.
//
// change of parent name does not effects the childs.
//
// changing the name, changes the real name also. but it will be
// compatible with OS. so its changed. and also maybe a random number 
// at the end of it.