using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nodes.Entities
{
    public class NodesTree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string parent { get; set; }
        public string title { get; set; }
        public DateTime created_At { get; set; }
        public int parentNode { get; set; }
        public int childNode { get; set; }
        public string timeZone { get; set; }
    }
}
