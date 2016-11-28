using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class House : Structures
    {
        public int Bedrooms { get; set; }

        public House()
        {
            this.Bedrooms = 0;
        }
    }

           
}
