using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Repository.DataObject
{
    public class OrderDetailDTO
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public long AlbumId { get; set; }
        public decimal Quantity { get; set; }
        public string UnitPrice { get; set; }
    }
}