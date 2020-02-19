using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.DTO
{
    public class MediaDto: BaseDto
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public int TypeMediaId { get; set; }
        public int FringeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
