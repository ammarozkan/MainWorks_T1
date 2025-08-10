using System.Net;
using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;

public class NotePagePieceComponent : NotePagePiece
{

    public RenderFragment? TheRenderFragment;
    public NotePagePieceComponent(NotePagePiece g)
    {
        this.Value = g.Value;
        this.Id = g.Id;
        this.Order = g.Order;
        this.PageId = g.PageId;
        this.type = g.type;
        TheRenderFragment = null;
    }
    public virtual NotePagePiece Change(NotePagePiece npp, string value, string method, out bool stateShouldChange)
    {
        stateShouldChange = false;
        npp.Value = value;
        Console.WriteLine($"Change to {value} from {npp.Value}!");
        return npp;
    }


    public virtual MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<p id='{Order}_Rendered' order='{Order}'> <b> Default test Component </b> {conv} </p>";
        return (MarkupString)res;
    }

    public virtual MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string res = $"<p id='{Order}_Rendered' order='{Order}'> <b> Default test Component </b> {conv} </p>";
        return (MarkupString)res;
    }

    public virtual RenderFragment RenderToFragment()
    {
        RenderFragment fragment = builder =>
        {
            builder.AddContent(0, Render());
        };
        TheRenderFragment = fragment;
        return fragment;
    }
}