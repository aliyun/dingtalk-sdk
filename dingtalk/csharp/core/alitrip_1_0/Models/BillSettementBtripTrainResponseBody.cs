// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementBtripTrainResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public BillSettementBtripTrainResponseBodyModule Module { get; set; }
        public class BillSettementBtripTrainResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<BillSettementBtripTrainResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementBtripTrainResponseBodyModuleDataList : TeaModel {
                [NameInMap("alipayTradeNo")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("applyId")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

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

                [NameInMap("capitalDirection")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascadeDepartment")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("changeFee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("coachNo")]
                [Validation(Required=false)]
                public string CoachNo { get; set; }

                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("costCenterNumber")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("deptDate")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("deptStation")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                [NameInMap("deptTime")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("orderPrice")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

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

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("runTime")]
                [Validation(Required=false)]
                public string RunTime { get; set; }

                [NameInMap("seatNo")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                [NameInMap("seatType")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

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

                [NameInMap("shortTicketNo")]
                [Validation(Required=false)]
                public string ShortTicketNo { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("ticketNo")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticketPrice")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                [NameInMap("trainNo")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                [NameInMap("trainType")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

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
