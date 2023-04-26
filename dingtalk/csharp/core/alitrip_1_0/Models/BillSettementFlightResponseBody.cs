// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementFlightResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public BillSettementFlightResponseBodyModule Module { get; set; }
        public class BillSettementFlightResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<BillSettementFlightResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementFlightResponseBodyModuleDataList : TeaModel {
                [NameInMap("advanceDay")]
                [Validation(Required=false)]
                public long? AdvanceDay { get; set; }

                [NameInMap("airlineCorpCode")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                [NameInMap("airlineCorpName")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                [NameInMap("alipayTradeNo")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("applyId")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("arrAirportCode")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arrCity")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("arrStation")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                [NameInMap("arrTime")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

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

                [NameInMap("btripCouponFee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                [NameInMap("buildFee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("capitalDirection")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascadeDepartment")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("changeFee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("corpPayOrderFee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("costCenterNumber")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                [NameInMap("depAirportCode")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("deptCity")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                [NameInMap("deptDate")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("deptStation")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                [NameInMap("deptTime")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("flightNo")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("insuranceFee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("itineraryNum")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                [NameInMap("itineraryPrice")]
                [Validation(Required=false)]
                public double? ItineraryPrice { get; set; }

                [NameInMap("mostDifferenceDeptTime")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                [NameInMap("mostDifferenceDiscount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                [NameInMap("mostDifferenceFlightNo")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                [NameInMap("mostDifferencePrice")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                [NameInMap("mostDifferenceReason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                [NameInMap("mostPrice")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                [NameInMap("negotiationCouponFee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

                [NameInMap("oilFee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("overApplyId")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("primaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("refundFee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                [NameInMap("refundUpgradeCost")]
                [Validation(Required=false)]
                public double? RefundUpgradeCost { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("repeatRefund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                [NameInMap("sealPrice")]
                [Validation(Required=false)]
                public double? SealPrice { get; set; }

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

                [NameInMap("ticketId")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                [NameInMap("travelerId")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("travelerJobNo")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("travelerName")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("upgradeCost")]
                [Validation(Required=false)]
                public double? UpgradeCost { get; set; }

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
