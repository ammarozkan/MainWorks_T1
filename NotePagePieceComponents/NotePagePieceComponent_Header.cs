using System.Net;
using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;

public class NotePagePieceComponent_Header : NotePagePieceComponent
{
    public NotePagePieceComponent_Header(NotePagePiece g) : base(g) { }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<h1 class='ClassicalEditable' id='{Order}_Rendered' order='{Order}' contenteditable='true'> {conv} </h1>";
        return (MarkupString)res;
    }
    public override MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<h1 class='ClassicalEditable' id='{Order}_Rendered'> {conv} </h1>";
        return (MarkupString)res;
    }
}