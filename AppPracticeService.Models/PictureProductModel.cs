using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPracticeService.Models
{
    public class PictureProductModel
    {
        public Guid PictureId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductColor { get; set; }
        public string ContentString { get; set; }
        public byte[] ContentBytes { get; set; }
        public bool Active { get; set; }
        public bool IsProfile { get; set; }
        public int DisplayOrder { get; set; }
    }
}
