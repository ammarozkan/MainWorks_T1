using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;
using System.Net;

public class NotePagePieceComponent_Image : NotePagePieceComponent
{
    public NotePagePieceComponent_Image(NotePagePiece g) : base(g) { }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string appendingStyles = "padding:12rem 19.4rem;margin:0.25rem;background-color:black;";
        string res = $"<div class='ImageEditable' id='{Order}_Rendered' order='{Order}' style=\"background-image:url('{conv}');{appendingStyles}\"> </div>";
        return (MarkupString)res;
    }

    public override MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string appendingStyles = "padding:12rem 19.4rem;margin:0.25rem;background-color:black;";
        string res = $"<div id='{Order}_Rendered' style=\"background-image:url('{conv}');{appendingStyles}\"> </div>";
        return (MarkupString)res;
    }

    public NotePagePiece Change(NotePagePiece npp, string value, string method, out bool stateShouldChange)
    {
        bool fake;
        stateShouldChange = true;
        return base.Change(npp, value, method, out fake);
    }
}