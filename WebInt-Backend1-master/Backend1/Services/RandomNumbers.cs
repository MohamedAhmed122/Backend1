using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Backend1.Services
{
    
    public class RandomNumbers : IRanomNumbers
    {
      
        public int GetNumber(int num) 
        {
            Random random = new Random();
            num = random.Next(10, 1000);

            return num;
        }
    }
}
