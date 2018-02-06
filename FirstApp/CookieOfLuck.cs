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
        private List<String> MessageStore = new List<String>() { "You will be lucky!", "You will fail!", "Everything will be fine", "Something wrong will take place"};

        public String NextMessage()
        {
            return MessageStore[Random.Next() % MessageStore.Count];
        }     

    }
}
