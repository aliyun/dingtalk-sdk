// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementBtripTrainResponseBody : TeaModel {
        /// <summary>
        /// module
        /// </summary>
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
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string ArrDate { get; set; }
                public string ArrStation { get; set; }
                public string ArrTime { get; set; }
                public string BillRecordTime { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerJobNo { get; set; }
                public string BookerName { get; set; }
                public string CapitalDirection { get; set; }
                public string CascadeDepartment { get; set; }
                public double? ChangeFee { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public double? Coupon { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string DeptDate { get; set; }
                public string DeptStation { get; set; }
                public string DeptTime { get; set; }
                public string FeeType { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OverApplyId { get; set; }
                public long? PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public double? RefundFee { get; set; }
                public string Remark { get; set; }
                public string RunTime { get; set; }
                public string SeatNo { get; set; }
                public string SeatType { get; set; }
                public double? ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public double? SettlementGrantFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public long? Status { get; set; }
                public string TicketNo { get; set; }
                public double? TicketPrice { get; set; }
                public string TrainNo { get; set; }
                public string TrainType { get; set; }
                public string TravelerId { get; set; }
                public string TravelerJobNo { get; set; }
                public string TravelerName { get; set; }
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
