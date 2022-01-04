// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreatWithholdingOrderAndPayRequest : TeaModel {
        /// <summary>
        /// 扣款金额
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [NameInMap("dingClientId")]
        [Validation(Required=false)]
        public string DingClientId { get; set; }

        /// <summary>
        /// isv组织id
        /// </summary>
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 其他资金渠道付款明细
        /// </summary>
        [NameInMap("otherPayChannelDetailInfoList")]
        [Validation(Required=false)]
        public List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> OtherPayChannelDetailInfoList { get; set; }
        public class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList : TeaModel {
            /// <summary>
            /// 渠道名称
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// 渠道类型
            /// </summary>
            [NameInMap("payChannelType")]
            [Validation(Required=false)]
            public string PayChannelType { get; set; }

            /// <summary>
            /// 渠道金额
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 支付渠道单号
            /// </summary>
            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

            /// <summary>
            /// 总优惠金额
            /// </summary>
            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

            /// <summary>
            /// 资金明细列表
            /// </summary>
            [NameInMap("fundToolDetailInfoList")]
            [Validation(Required=false)]
            public List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> FundToolDetailInfoList { get; set; }
            public class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList : TeaModel {
                /// <summary>
                /// 资金工具名称
                /// </summary>
                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                /// <summary>
                /// 金额
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// 资金明细创建时间
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// 资金明细完成时间
                /// </summary>
                [NameInMap("gmtFinish")]
                [Validation(Required=false)]
                public string GmtFinish { get; set; }

                /// <summary>
                /// 是否是优惠工具
                /// </summary>
                [NameInMap("promotionFundTool")]
                [Validation(Required=false)]
                public bool? PromotionFundTool { get; set; }

                /// <summary>
                /// 扩展信息
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

            }

        }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// 付款人staffId
        /// </summary>
        [NameInMap("payerUserId")]
        [Validation(Required=false)]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 代扣备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 子机构编号
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// 代扣过期时间
        /// </summary>
        [NameInMap("timeOutExpress")]
        [Validation(Required=false)]
        public string TimeOutExpress { get; set; }

        /// <summary>
        /// 代扣标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
