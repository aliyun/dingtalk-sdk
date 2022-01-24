// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementCarResponseBody : TeaModel {
        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public BillSettementCarResponseBodyModule Module { get; set; }
        public class BillSettementCarResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public long? Category { get; set; }
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<BillSettementCarResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementCarResponseBodyModuleDataList : TeaModel {
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string ArrCity { get; set; }
                public string ArrDate { get; set; }
                public string ArrLocation { get; set; }
                public string ArrTime { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerName { get; set; }
                public string BusinessCategory { get; set; }
                public string CapitalDirection { get; set; }
                public string CarLevel { get; set; }
                public string CascadeDepartment { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public double? Coupon { get; set; }
                public double? CouponPrice { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string DeptCity { get; set; }
                public string DeptDate { get; set; }
                public string DeptLocation { get; set; }
                public string DeptTime { get; set; }
                public string EstimateDriveDistance { get; set; }
                public double? EstimatePrice { get; set; }
                public string FeeType { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public string Memo { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OverApplyId { get; set; }
                public double? PersonSettleFee { get; set; }
                public string PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public string ProviderName { get; set; }
                public string RealDriveDistance { get; set; }
                public string RealFromAddr { get; set; }
                public string RealToAddr { get; set; }
                public string ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public string SpecialOrder { get; set; }
                public string SpecialReason { get; set; }
                public long? Status { get; set; }
                public string TravelerId { get; set; }
                public string TravelerName { get; set; }
                public string UserConfirmDesc { get; set; }
                public string BookerJobNo { get; set; }
                public string TravelerJobNo { get; set; }
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
