using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;
using System.Net;

public class NotePagePieceComponent_Link : NotePagePieceComponent
{
    public NotePagePieceComponent_Link(NotePagePiece g) : base(g) { }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<a href='{conv}' class='LinkEditable' id='{Order}_Rendered' order='{Order}'> {conv} </a>";
        return (MarkupString)res;
    }

    public override MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<a href='{conv}' id='{Order}_Rendered'> {conv} </a>";
        return (MarkupString)res;
    }

    public NotePagePiece Change(NotePagePiece npp, string value, string method, out bool stateShouldChange)
    {
        bool fake;
        stateShouldChange = true;
        return base.Change(npp, value, method, out fake);
    }
}