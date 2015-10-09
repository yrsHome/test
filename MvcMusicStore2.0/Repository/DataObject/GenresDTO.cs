using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Repository.DataObject
{
    public class GenresDTO
    {
        public Decimal GenreId { get; set; }
        public String Name { get; set; }
        public String AlbumId { get; set; }
    }
}