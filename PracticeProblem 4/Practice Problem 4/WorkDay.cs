using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_4
{
    internal class WorkDay
    {
        public int Cal(DateTime startDate, DateTime endDate)
        {
            int workdays = 0;

            
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdays++;
                }
            }

            return workdays;
        }
    }
}
