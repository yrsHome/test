using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Repository.DataObject
{
    public class AlbumDTO
    {
        public long AlbumId { get;set; }
        public long GenreId { get;set; }
        public long ArtistID { get;set; }
        public String Title { get;set; }
        public String Price { get;set; }
        public String AlbumArtual { get;set; }
    }
}