using WORKS_T1.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Net;

public class NotePagePieceComponent_NotePageLink : NotePagePieceComponent
{
    public NotePagePieceComponent_NotePageLink(NotePagePiece g) : base(g) { }

    string? getPageTitle()
    {
        var context = SystemHelper.GetDbContextFactory().CreateDbContext();
        int parsed = 0;
        if (int.TryParse(Value, out parsed))
        {
            NotePage? np = context.NotePage.FirstOrDefault(m => m.Id == int.Parse(Value));
            if (np != null) return np.Title;
        }
        return null;
    }
    public override MarkupString Render()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string extraStyles = "background-color:rgb(30,30,30);color:lightgray;padding:0.5rem;border-radius:3px;text-align:center;text-decoration:none;float:left;padding:0.5rem;margin:0.25rem;";


        string? pagetitle = getPageTitle();
        string url = "";
        if (pagetitle == null)
        {
            pagetitle = "Page Title Not Found";
        }
        else
        {
            url = $"href='/pagerenderer/{conv}'";
        }

        string link = $"<i>page</i> | <b>{pagetitle}</b>";
        string res = $"<a {url} class='NotePageLink' id='{Order}_Rendered' order='{Order}' style='{extraStyles}'>{link}</a>";
        return (MarkupString)res;
    }

    public override MarkupString Preview()
    {
        string? conv = WebUtility.HtmlEncode(Value);
        string extraStyles = "background-color:rgb(30,30,30);color:lightgray;padding:0.5rem;border-radius:3px;text-align:center;text-decoration:none;float:left;padding:0.5rem;margin:0.25rem;";


        string? pagetitle = getPageTitle();
        string url = "";
        if (pagetitle == null)
        {
            pagetitle = "Page Title Not Found";
        }
        else
        {
            url = $"href='/pagerenderer/{conv}'";
        }

        string link = $"<i>page</i> | <b>{pagetitle}</b>";
        string res = $"<p><a {url} class='NotePageLink' id='{Order}_Rendered' style='{extraStyles}'>{link}</a></p>";
        return (MarkupString)res;
    }
    
    public NotePagePiece Change(NotePagePiece npp, string value, string method, out bool stateShouldChange)
    {
        bool fake;
        stateShouldChange = true;
        return base.Change(npp, value, method, out fake);
    }
}