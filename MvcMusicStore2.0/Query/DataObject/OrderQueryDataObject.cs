using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Query
{
    public class OrderQueryDataObject
    {
        public string Code { get; set; }
        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public int Pieces { get; set; }
        public decimal Weight { get; set; }
        //public Guid UniqueID { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderTime { get; set; }
        public string Categories { get; set; }
        public string Factories { get; set; }
        public string Warehouses { get; set; }
        public string Suppername { get; set; }
        public int TotalRows { get; set; }
        public long LadingID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalWeight { get; set; }
        public int TotalPieces { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
    public enum OrderStatus
    {
        待确认 = 100,
        待收款 = 101,
        待支款 = 102,   // add by jbo
        待实提 = 103,
        待结算 = 104,
        待开票 = 105,
        已撤销 = 200,
        已开票 = 300  //暂不需要
    }
    public enum PaymentStatus
    {
        初始值 = 0,
        待申请支款 = 100,
        待经理审核 = 101,
        待财务审核 = 102,
        支款完成 = 103
    }
}