using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location.Services.Models
{
    public class SuburbLocationModel
    {
        public int id { get; set; }
        public string suburbName { get; set; } = "";
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
