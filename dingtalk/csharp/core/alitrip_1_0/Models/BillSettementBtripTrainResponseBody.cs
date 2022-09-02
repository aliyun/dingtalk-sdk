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
            public List<BillSettementBtripTrainResponseBodyModuleDataList> DataList { get; set; }
            public class BillSettementBtripTrainResponseBodyModuleDataList : TeaModel {
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
                /// 到达日期
                /// </summary>
                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// 到达站点
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
                /// 改签手续费
                /// </summary>
                [NameInMap("changeFee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

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
                /// 折扣率
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

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
                /// 出发日期
                /// </summary>
                [NameInMap("deptDate")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// 出发站
                /// </summary>
                [NameInMap("deptStation")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// 出发时间
                /// </summary>
                [NameInMap("deptTime")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

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
                /// 项目编号
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
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 运行时长
                /// </summary>
                [NameInMap("runTime")]
                [Validation(Required=false)]
                public string RunTime { get; set; }

                /// <summary>
                /// 座位号
                /// </summary>
                [NameInMap("seatNo")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                /// <summary>
                /// 坐席
                /// </summary>
                [NameInMap("seatType")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// 服务费，仅在feeType 6007、6008中展示
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
                /// 票面票号
                /// </summary>
                [NameInMap("ticketNo")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// 票价
                /// </summary>
                [NameInMap("ticketPrice")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// 车次号
                /// </summary>
                [NameInMap("trainNo")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// 车次类型
                /// </summary>
                [NameInMap("trainType")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

                /// <summary>
                /// 出行人useId
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
            /// 记账更新开始时间
            /// </summary>
            [NameInMap("periodEnd")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// 记账更新结束时间
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
