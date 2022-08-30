using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajd.HackerNewsClient.Core.Services
{
    internal class ItemService : IItemService
    {
        // Does Stuff Stuff
        public void DoStuff()
        {
            var i = 5;
            const int j = 10;

            i++;

            if (i < 1)
            {
                if (j > 1)
                {
                    Console.WriteLine("blah");
                }
            }
        }
    }
}
