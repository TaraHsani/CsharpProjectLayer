using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Canstract
{
    public class BaseEntity
    {


        public BaseEntity()
        {
            IsActive = true;
            CreationDate = DateTime.Now;
            Random random = new Random();
            Id = random.Next(minValue:10, maxValue: 1000);
        }

        public BaseEntity(bool isActive, int minValue, int maxValue)
        {
            IsActive = isActive;
            CreationDate = DateTime.Now;
            Random random = new Random();
            Id = random.Next(minValue: 10, maxValue: 1000);

        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
       
    }

    

}
