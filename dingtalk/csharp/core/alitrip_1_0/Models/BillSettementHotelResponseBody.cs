// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementHotelResponseBody : TeaModel {
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
                [NameInMap("alipayTradeNo")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("applyId")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("billRecordTime")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("bookTime")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                [NameInMap("bookerId")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("bookerJobNo")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("bookerName")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                [NameInMap("capitalDirection")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascadeDepartment")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("checkInDate")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                [NameInMap("checkoutDate")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("corpRefundFee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                [NameInMap("corpTotalFee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("costCenterNumber")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                [NameInMap("fuPointFee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                [NameInMap("hotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("isNegotiation")]
                [Validation(Required=false)]
                public bool? IsNegotiation { get; set; }

                [NameInMap("isShareStr")]
                [Validation(Required=false)]
                public string IsShareStr { get; set; }

                [NameInMap("nights")]
                [Validation(Required=false)]
                public long? Nights { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("orderPrice")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("orderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("overApplyId")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("personRefundFee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                [NameInMap("personSettlePrice")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                [NameInMap("primaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("promotionFee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("roomNumber")]
                [Validation(Required=false)]
                public long? RoomNumber { get; set; }

                [NameInMap("roomPrice")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                [NameInMap("roomType")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                [NameInMap("serviceFee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settlementFee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                [NameInMap("settlementGrantFee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                [NameInMap("settlementTime")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlementType")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("totalNights")]
                [Validation(Required=false)]
                public long? TotalNights { get; set; }

                [NameInMap("travelerId")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("travelerJobNo")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("travelerName")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("voucherType")]
                [Validation(Required=false)]
                public long? VoucherType { get; set; }

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

        }

        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public long? ResultCode { get; set; }

        [NameInMap("resultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
