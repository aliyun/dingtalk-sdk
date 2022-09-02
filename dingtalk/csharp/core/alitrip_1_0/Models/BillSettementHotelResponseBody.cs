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
            public List<BillSettementHotelResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementHotelResponseBodyModuleDataList : TeaModel {
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
                /// 入住时间
                /// </summary>
                [NameInMap("checkInDate")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                /// <summary>
                /// 离店时间
                /// </summary>
                [NameInMap("checkoutDate")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                /// <summary>
                /// 入住城市
                /// </summary>
                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// 城市编码
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// 企业退款金额
                /// </summary>
                [NameInMap("corpRefundFee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                /// <summary>
                /// 企业支付金额
                /// </summary>
                [NameInMap("corpTotalFee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                /// <summary>
                /// 成本中心名称
                /// </summary>
                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// 成本中心编码
                /// </summary>
                [NameInMap("costCenterNumber")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

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
                /// 费用类型
                /// </summary>
                [NameInMap("feeType")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// 杂费
                /// </summary>
                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                /// <summary>
                /// 福豆支付
                /// </summary>
                [NameInMap("fuPointFee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                /// <summary>
                /// 酒店名称
                /// </summary>
                [NameInMap("hotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

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
                /// 是否协议价
                /// </summary>
                [NameInMap("isNegotiation")]
                [Validation(Required=false)]
                public bool? IsNegotiation { get; set; }

                /// <summary>
                /// 是否合住
                /// </summary>
                [NameInMap("isShareStr")]
                [Validation(Required=false)]
                public string IsShareStr { get; set; }

                /// <summary>
                /// 入住天数
                /// </summary>
                [NameInMap("nights")]
                [Validation(Required=false)]
                public long? Nights { get; set; }

                /// <summary>
                /// 订单号
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
                /// 订单类型
                /// </summary>
                [NameInMap("orderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// 超标审批单号
                /// </summary>
                [NameInMap("overApplyId")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// 个人退款金额
                /// </summary>
                [NameInMap("personRefundFee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                /// <summary>
                /// 个人支付金额
                /// </summary>
                [NameInMap("personSettlePrice")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                /// <summary>
                /// 主键id
                /// </summary>
                [NameInMap("primaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

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
                /// 优惠券
                /// </summary>
                [NameInMap("promotionFee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 房间数
                /// </summary>
                [NameInMap("roomNumber")]
                [Validation(Required=false)]
                public long? RoomNumber { get; set; }

                /// <summary>
                /// 房价
                /// </summary>
                [NameInMap("roomPrice")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                /// <summary>
                /// 房间类型
                /// </summary>
                [NameInMap("roomType")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                /// <summary>
                /// 服务费,仅在 feeType 20111、20112中展示
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
                /// 总间夜数
                /// </summary>
                [NameInMap("totalNights")]
                [Validation(Required=false)]
                public long? TotalNights { get; set; }

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
                /// 发票类型
                /// </summary>
                [NameInMap("voucherType")]
                [Validation(Required=false)]
                public long? VoucherType { get; set; }

            }

            /// <summary>
            /// 记账更新结束日期
            /// </summary>
            [NameInMap("periodEnd")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// 记账更新开始日期
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
