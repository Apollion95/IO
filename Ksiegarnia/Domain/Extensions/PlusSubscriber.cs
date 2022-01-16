using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PlusSubscriber : Subscriber
    {
        private DateTime daysBook;
        private int _FreeBookEveryWeek {get;set;}
        public PlusSubscriber(int sub_id, DateTime sub_start, User user, DateTime sub_end, bool is_active, IActions actions) : base(sub_id, sub_start, user, sub_end, is_active, actions)
        {
            _FreeBookEveryWeek = 0;
            daysBook = sub_start;
        }

        public void FreeBook()
        {
            var day = daysBook;
            var toDay = DateTime.UtcNow;

            if(toDay >= (day + TimeSpan.FromDays(7)))
            {
                _FreeBookEveryWeek+=1;
                toDay = daysBook;
            }
            else
            {
                Console.WriteLine($"Nie otrzymałes darmowej ksiazki brakuje: {(day + TimeSpan.FromDays(7))-toDay} dni.");
            }

        }
        public void TakeFreeBook()
        {

            if (_FreeBookEveryWeek>0)
            {
                _FreeBookEveryWeek--;
            }

        }
    }
}
