using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;
using System.Net;
using WORKS_T1.Components.Pages.Files;

public class NotePagePieceComponent_FileObject : NotePagePieceComponent
{
    public NotePagePieceComponent_FileObject(NotePagePiece g) : base(g) { }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        Console.WriteLine($"{conv}!");
        int FileId;
        if (!int.TryParse(conv, out FileId)) return (MarkupString)$"<p class='FileObjectEditable' id='{Order}_Rendered' order='{Order}'>File not available. (value didnt parsed)</p>";

        FileObject? fo = SystemHelper.getFileObjectFromId(FileId);
        if (fo == null) return (MarkupString)$"<p class='FileObjectEditable' id='{Order}_Rendered' order='{Order}'>File not available. (id not exists)</p>";

        string res = $"<a href='fileview?FolderId={fo.BelongingFolderCode}' class='FileObjectEditable' id='{Order}_Rendered' order='{Order}' contenteditable='true'> {fo.Name} </a>";
        return (MarkupString)res;
    }

    public override MarkupString Preview()
    {
        return Render();
    }

    public override NotePagePiece Change(NotePagePiece npp, string value, string method, out bool stateShouldChange)
    {
        bool fake;
        stateShouldChange = true;
        return base.Change(npp, value, method, out fake);
    }
}