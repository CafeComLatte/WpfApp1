using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EventVO
    {
    }
    public class EventContent
    {
        public string Image { get; set; }
    }

    public class EventProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }

        public string Image { get; set; }
    }
}
