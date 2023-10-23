using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBasics.Models.Home
{
    public class IndexVm
    {
        public string HeutigerTag { get; set; }

        public string Benutzername { get; set; }

        public int Lieblingszahl { get; set; }
    }
}