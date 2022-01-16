using Domain.Entities;
using Domain.ExtrensionsMetods;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public class Test
    {
        public void Tests()
        {
            var premium = new RegularSubscriberActions();
            
            var a = new PlusSubscriber(3,DateTime.Now,new User(), DateTime.Now+TimeSpan.FromHours(6),true, premium);
            a.Read();
            a.FreeBook();
            a.TakeFreeBook();
            
        }
    }
}
