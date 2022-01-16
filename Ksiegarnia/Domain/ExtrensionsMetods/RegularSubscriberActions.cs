using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ExtrensionsMetods
{
    public class RegularSubscriberActions : IActions
    {

        public int PosiblePagesToRead { get; set; }

        public RegularSubscriberActions()
        {
            PosiblePagesToRead = 20;
        }
        public void Read()
        {
            if (PosiblePagesToRead == 0)
            {
                throw new Exception("You can't read any more pages");
            }
            else
            {
                PosiblePagesToRead--;
            }
            
        }



       
    }
}
