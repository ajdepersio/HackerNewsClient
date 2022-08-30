using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajd.HackerNewsClient.Data.Models
{
    internal class User
    {
        public string? About { get; set; }

        public int Created { get; set; }

        public int Delay { get; set; }

        public string? Id { get; set; }

        public int Karma { get; set; }

        public int[]? Submitted { get; set; }
    }
}
