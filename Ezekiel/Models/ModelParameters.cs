using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ezekiel.Models
{
    public class ModelParameters
    {
        public string PageName { get; set; }
        public string Info { get; set; }
        public List<ObjectList> ObjectList { get; set; }
    }

    public class ObjectList
    {
        public string PropName { get; set; }
        public int PropVal { get; set; }
    }
}