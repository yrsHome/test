using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Repository.DataObject
{
    public class CartDTO
    {
        public long RecordId { get; set; }
        public String CardId { get; set; }
        public long AlbumId { get; set; }
        public long Count { get; set; }
        public DateTime DateCreated { get; set; }
    }
}