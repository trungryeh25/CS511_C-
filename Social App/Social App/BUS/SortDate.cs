using Social_App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.BUS
{
    public class SortDate : IComparer<DTO.Message>
    {
        public int Compare(Message x, Message y)
        {
            if (x == null || y == null) return 0;
            return DateTime.Compare(x.message_timestamp, y.message_timestamp);
        }
    }
}
