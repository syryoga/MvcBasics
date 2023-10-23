using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBasics.Models.Home
{
    //Ein Vorteil vom Empfangen von Daten mit Hilfe einer Klasse: es können Data-Annotations verwendet werden
    public class IndexPostModel
    {
        public string Username { get; set; }
        public int? Lieblingszahl { get; set; }
    }
}