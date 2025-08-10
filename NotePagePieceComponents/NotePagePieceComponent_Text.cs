using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;
using System.Net;

public class NotePagePieceComponent_Text : NotePagePieceComponent
{
    public NotePagePieceComponent_Text(NotePagePiece g) : base(g) { }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<p class='ClassicalEditable' id='{Order}_Rendered' order='{Order}' contenteditable='true'> {conv} </p>";
        return (MarkupString)res;
    }

    public override MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<p id='{Order}_Rendered'> {conv} </p>";
        return (MarkupString)res;
    }
}