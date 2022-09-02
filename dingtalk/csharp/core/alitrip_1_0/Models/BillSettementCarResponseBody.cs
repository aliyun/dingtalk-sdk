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
            /// <summary>
            /// 类目
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// 企业id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 数据集合
            /// </summary>
            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<BillSettementCarResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementCarResponseBodyModuleDataList : TeaModel {
                /// <summary>
                /// 支付交易流水号
                /// </summary>
                [NameInMap("alipayTradeNo")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// 审批单号
                /// </summary>
                [NameInMap("applyId")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// 到达城市
                /// </summary>
                [NameInMap("arrCity")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// 到达日期
                /// </summary>
                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// 到达地
                /// </summary>
                [NameInMap("arrLocation")]
                [Validation(Required=false)]
                public string ArrLocation { get; set; }

                /// <summary>
                /// 到达时间
                /// </summary>
                [NameInMap("arrTime")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// 入账时间
                /// </summary>
                [NameInMap("billRecordTime")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// 预定时间
                /// </summary>
                [NameInMap("bookTime")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// 预定人use id
                /// </summary>
                [NameInMap("bookerId")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// 预订人工号
                /// </summary>
                [NameInMap("bookerJobNo")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                /// <summary>
                /// 预订人名称
                /// </summary>
                [NameInMap("bookerName")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// 用车事由
                /// </summary>
                [NameInMap("businessCategory")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                /// <summary>
                /// 资金方向
                /// </summary>
                [NameInMap("capitalDirection")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// 车型
                /// </summary>
                [NameInMap("carLevel")]
                [Validation(Required=false)]
                public string CarLevel { get; set; }

                /// <summary>
                /// 级联部门
                /// </summary>
                [NameInMap("cascadeDepartment")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// 成本中心名称
                /// </summary>
                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// 成本中心编号
                /// </summary>
                [NameInMap("costCenterNumber")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// 优惠券
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                /// <summary>
                /// 优惠金额
                /// </summary>
                [NameInMap("couponPrice")]
                [Validation(Required=false)]
                public double? CouponPrice { get; set; }

                /// <summary>
                /// 末级部门
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// 部门id
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// 出发城市
                /// </summary>
                [NameInMap("deptCity")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// 出发日期
                /// </summary>
                [NameInMap("deptDate")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// 出发地
                /// </summary>
                [NameInMap("deptLocation")]
                [Validation(Required=false)]
                public string DeptLocation { get; set; }

                /// <summary>
                /// 出发时间
                /// </summary>
                [NameInMap("deptTime")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// 预估行驶距离
                /// </summary>
                [NameInMap("estimateDriveDistance")]
                [Validation(Required=false)]
                public string EstimateDriveDistance { get; set; }

                /// <summary>
                /// 预估金额
                /// </summary>
                [NameInMap("estimatePrice")]
                [Validation(Required=false)]
                public double? EstimatePrice { get; set; }

                /// <summary>
                /// 费用类型
                /// </summary>
                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// 序号
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// 发票抬头
                /// </summary>
                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// 用车事由
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// 订单id
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// 订单金额
                /// </summary>
                [NameInMap("orderPrice")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                /// <summary>
                /// 超标审批单号
                /// </summary>
                [NameInMap("overApplyId")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// 个人支付金额
                /// </summary>
                [NameInMap("personSettleFee")]
                [Validation(Required=false)]
                public double? PersonSettleFee { get; set; }

                [NameInMap("primaryId")]
                [Validation(Required=false)]
                public string PrimaryId { get; set; }

                /// <summary>
                /// 项目编码
                /// </summary>
                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// 项目名称
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// 供应商
                /// </summary>
                [NameInMap("providerName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

                /// <summary>
                /// 实际行驶距离
                /// </summary>
                [NameInMap("realDriveDistance")]
                [Validation(Required=false)]
                public string RealDriveDistance { get; set; }

                /// <summary>
                /// 实际上车点
                /// </summary>
                [NameInMap("realFromAddr")]
                [Validation(Required=false)]
                public string RealFromAddr { get; set; }

                /// <summary>
                /// 实际下车点
                /// </summary>
                [NameInMap("realToAddr")]
                [Validation(Required=false)]
                public string RealToAddr { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 服务费，仅在feeType 40111 中展示
                /// </summary>
                [NameInMap("serviceFee")]
                [Validation(Required=false)]
                public string ServiceFee { get; set; }

                /// <summary>
                /// 结算金额
                /// </summary>
                [NameInMap("settlementFee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// 预存赠送金额消费
                /// </summary>
                [NameInMap("settlementGrantFee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// 结算时间
                /// </summary>
                [NameInMap("settlementTime")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// 结算类型
                /// </summary>
                [NameInMap("settlementType")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// 特别关注订单
                /// </summary>
                [NameInMap("specialOrder")]
                [Validation(Required=false)]
                public string SpecialOrder { get; set; }

                /// <summary>
                /// 特别关注原因
                /// </summary>
                [NameInMap("specialReason")]
                [Validation(Required=false)]
                public string SpecialReason { get; set; }

                /// <summary>
                /// 入账状态
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// 子订单号
                /// </summary>
                [NameInMap("subOrderId")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// 出行人use id
                /// </summary>
                [NameInMap("travelerId")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// 出行人工号
                /// </summary>
                [NameInMap("travelerJobNo")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                /// <summary>
                /// 出行人名称
                /// </summary>
                [NameInMap("travelerName")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// 员工是否认可
                /// </summary>
                [NameInMap("userConfirmDesc")]
                [Validation(Required=false)]
                public string UserConfirmDesc { get; set; }

                /// <summary>
                /// 发票类型
                /// </summary>
                [NameInMap("voucherType")]
                [Validation(Required=false)]
                public long? VoucherType { get; set; }

            }

            /// <summary>
            /// 记账更新开始日期
            /// </summary>
            [NameInMap("periodEnd")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// 记账更新结束日期
            /// </summary>
            [NameInMap("periodStart")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            /// <summary>
            /// 总数量
            /// </summary>
            [NameInMap("totalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

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
