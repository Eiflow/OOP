using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBil
{
    public interface IBil
    {
        string Farve { get; set; }
        int Km { get; }
        void UdskrivBil();
    }
}
