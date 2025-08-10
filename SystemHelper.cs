
using Microsoft.EntityFrameworkCore;
using WORKS_T1.Data;
using WORKS_T1.Models;

public class IndependentLink
{
    public string value = string.Empty;
    public int type = 0;
}
public static class SystemHelper
{
    public static IServiceProvider? Provider { get; set; }

    public static IndependentLink? il { get; set; } = new();

    public static void ilSetFile(string fileCode)
    {
        il = new();
        il.value = fileCode;
        il.type = 6;
    }

    public static string getIlValueByType(int type)
    {
        if (il != null && il!.type == type) return il.value;
        else return string.Empty;
    }

    public static IDbContextFactory<WORKS_T1.Data.WORKS_T1_Context> GetDbContextFactory()
    {
        return Provider!.GetRequiredService<IDbContextFactory<WORKS_T1.Data.WORKS_T1_Context>>();
    }

    public static FileObject? getFileObjectFromId(int Id)
    {
        using WORKS_T1_Context context = GetDbContextFactory().CreateDbContext();
        FileObject? obj = context.FileObject.FirstOrDefault(m => m.Id == Id);
        context.Dispose();
        return obj;
    }

}