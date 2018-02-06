using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    
    class CookieOfLuck
    {
        private Random Random = new Random();

        public String NextMessage()
        {
            return (Random.Next() % 2 == 0) ? "Very Good!" : "Very Bad!";
        }     

    }
}
