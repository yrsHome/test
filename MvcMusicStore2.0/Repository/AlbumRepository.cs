using MvcMusicStore.Repository.DataObject;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Query
{
    public interface AlbumRepository : IRepository<AlbumDTO>
    {
        void AddBill(AlbumDTO album);

        void EditBill(AlbumDTO album);

        void EditBillPart(AlbumDTO album, Expression<Func<AlbumDTO, object>> expression = null);

        AlbumDTO FindByOrderID(Guid orderID);

        AlbumDTO FindByOrderGuid(string OrderUniqueID);
        AlbumDTO FindByBlId(long BlId);

        void RegisterNew(AlbumDTO album);
        void RegisterModify(AlbumDTO album);
    }
}
