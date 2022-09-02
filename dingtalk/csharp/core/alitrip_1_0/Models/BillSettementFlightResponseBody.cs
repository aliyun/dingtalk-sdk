// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementFlightResponseBody : TeaModel {
        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public BillSettementFlightResponseBodyModule Module { get; set; }
        public class BillSettementFlightResponseBodyModule : TeaModel {
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
            public List<BillSettementFlightResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementFlightResponseBodyModuleDataList : TeaModel {
                /// <summary>
                /// 提前预定天数
                /// </summary>
                [NameInMap("advanceDay")]
                [Validation(Required=false)]
                public long? AdvanceDay { get; set; }

                /// <summary>
                /// 航司三字码
                /// </summary>
                [NameInMap("airlineCorpCode")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                /// <summary>
                /// 航司名称
                /// </summary>
                [NameInMap("airlineCorpName")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                /// <summary>
                /// 交易流水号
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
                /// 到达机场二字码
                /// </summary>
                [NameInMap("arrAirportCode")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

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
                /// 到达机场
                /// </summary>
                [NameInMap("arrStation")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

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
                /// 预订人use id
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
                /// 商旅优惠金额
                /// </summary>
                [NameInMap("btripCouponFee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                /// <summary>
                /// 基建费
                /// </summary>
                [NameInMap("buildFee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

                /// <summary>
                /// 舱位
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// 舱位码
                /// </summary>
                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// 资金方向
                /// </summary>
                [NameInMap("capitalDirection")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// 级联部门
                /// </summary>
                [NameInMap("cascadeDepartment")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// 改签费用
                /// </summary>
                [NameInMap("changeFee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// 订单金额
                /// </summary>
                [NameInMap("corpPayOrderFee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

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
                /// 起飞机场二字码
                /// </summary>
                [NameInMap("depAirportCode")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

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
                /// 起飞城市
                /// </summary>
                [NameInMap("deptCity")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// 起飞日期
                /// </summary>
                [NameInMap("deptDate")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// 起飞机场
                /// </summary>
                [NameInMap("deptStation")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// 起飞时间
                /// </summary>
                [NameInMap("deptTime")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// 折扣率
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// 费用类型
                /// </summary>
                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// 航班号
                /// </summary>
                [NameInMap("flightNo")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// 序号
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// 保险费
                /// </summary>
                [NameInMap("insuranceFee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                /// <summary>
                /// 发票抬头
                /// </summary>
                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// 行程单打印序号
                /// </summary>
                [NameInMap("itineraryNum")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                /// <summary>
                /// 行程单金额
                /// </summary>
                [NameInMap("itineraryPrice")]
                [Validation(Required=false)]
                public double? ItineraryPrice { get; set; }

                /// <summary>
                /// 低价提醒（起飞时间）
                /// </summary>
                [NameInMap("mostDifferenceDeptTime")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                /// <summary>
                /// 低价提醒（折扣）
                /// </summary>
                [NameInMap("mostDifferenceDiscount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                /// <summary>
                /// 低价提醒(航班号)
                /// </summary>
                [NameInMap("mostDifferenceFlightNo")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                /// <summary>
                /// 低价提醒(与最低价差额)
                /// </summary>
                [NameInMap("mostDifferencePrice")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                /// <summary>
                /// 不选低价原因
                /// </summary>
                [NameInMap("mostDifferenceReason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                /// <summary>
                /// 低价航班价格
                /// </summary>
                [NameInMap("mostPrice")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                /// <summary>
                /// 协议价优惠金额
                /// </summary>
                [NameInMap("negotiationCouponFee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

                /// <summary>
                /// 燃油费
                /// </summary>
                [NameInMap("oilFee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                /// <summary>
                /// 订单号
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// 超标审批单号
                /// </summary>
                [NameInMap("overApplyId")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// 主键id
                /// </summary>
                [NameInMap("primaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// 项目代码
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
                /// 退款手续费
                /// </summary>
                [NameInMap("refundFee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                /// <summary>
                /// 改签退票手续费
                /// </summary>
                [NameInMap("refundUpgradeCost")]
                [Validation(Required=false)]
                public double? RefundUpgradeCost { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 是否重复退
                /// </summary>
                [NameInMap("repeatRefund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                /// <summary>
                /// 销售价
                /// </summary>
                [NameInMap("sealPrice")]
                [Validation(Required=false)]
                public double? SealPrice { get; set; }

                /// <summary>
                /// 服务费，仅在feeType  11001、11002中展示
                /// </summary>
                [NameInMap("serviceFee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

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
                /// 入账状态
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// 行程单号
                /// </summary>
                [NameInMap("ticketId")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

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
                /// 改签差价
                /// </summary>
                [NameInMap("upgradeCost")]
                [Validation(Required=false)]
                public double? UpgradeCost { get; set; }

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
            /// 总数据量
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
