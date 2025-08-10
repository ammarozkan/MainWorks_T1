
namespace WORKS_T1.Data
{
    public class GlobalAgendaConfigs
    {
        public static int days = 0;
        public static int hours = 2;
        public static int minutes = 0;

        public static void SetConfigs(int _days, int _hours, int _minutes)
        {
            days = _days;
            hours = _hours;
            minutes = _minutes;
        }
    }

    public class GlobalPageConfigs
    {
        public static int PageRId = 4;
    }
}