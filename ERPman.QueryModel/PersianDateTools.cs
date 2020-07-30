using System;
using System.Globalization;

namespace ERPman.QueryModel
{
    public static class PersianDateTools
    {
        public static string ToPersianDate(this DateTime date)
        {
            PersianCalendar pcal = new PersianCalendar();
            var result = pcal.GetYear(date) + "/" +
                         (pcal.GetMonth(date) < 10
                             ? "0" + pcal.GetMonth(date).ToString()
                             : pcal.GetMonth(date).ToString()) + "/" +
                         (pcal.GetDayOfMonth(date) < 10
                             ? "0" + pcal.GetDayOfMonth(date).ToString()
                             : pcal.GetDayOfMonth(date).ToString());
            return result;
        }
    }
}
