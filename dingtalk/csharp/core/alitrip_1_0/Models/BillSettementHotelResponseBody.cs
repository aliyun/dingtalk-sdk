// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementHotelResponseBody : TeaModel {
        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public BillSettementHotelResponseBodyModule Module { get; set; }
        public class BillSettementHotelResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public long? Category { get; set; }
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<BillSettementHotelResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementHotelResponseBodyModuleDataList : TeaModel {
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerName { get; set; }
                public string CapitalDirection { get; set; }
                public string CascadeDepartment { get; set; }
                public string CheckInDate { get; set; }
                public string CheckoutDate { get; set; }
                public string City { get; set; }
                public string CityCode { get; set; }
                public double? CorpRefundFee { get; set; }
                public double? CorpTotalFee { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string FeeType { get; set; }
                public double? Fees { get; set; }
                public double? FuPointFee { get; set; }
                public string HotelName { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public bool? IsNegotiation { get; set; }
                public string IsShareStr { get; set; }
                public long? Nights { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OrderType { get; set; }
                public string OverApplyId { get; set; }
                public double? PersonRefundFee { get; set; }
                public double? PersonSettlePrice { get; set; }
                public long? PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public double? PromotionFee { get; set; }
                public long? RoomNumber { get; set; }
                public double? RoomPrice { get; set; }
                public string RoomType { get; set; }
                public double? ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public long? Status { get; set; }
                public long? TotalNights { get; set; }
                public string TravelerId { get; set; }
                public string TravelerName { get; set; }
                public string BookerJobNo { get; set; }
                public string TravelerJobNo { get; set; }
            }
            [NameInMap("periodEnd")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }
            [NameInMap("periodStart")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }
            [NameInMap("totalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }
        };

        /// <summary>
        /// 结果code
        /// </summary>
        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public long? ResultCode { get; set; }

        /// <summary>
        /// 结果msg
        /// </summary>
        [NameInMap("resultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
