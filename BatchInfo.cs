using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFirstForm
{
    [Serializable]
    public class BatchInfo
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }

        public string Trainer { get; set; }
    }
}
