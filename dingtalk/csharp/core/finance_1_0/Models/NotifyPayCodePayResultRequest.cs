// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyPayCodePayResultRequest : TeaModel {
        /// <summary>
        /// 付款码值
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 交易开始时间
        /// </summary>
        [NameInMap("gmtTradeCreate")]
        [Validation(Required=false)]
        public string GmtTradeCreate { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [NameInMap("gmtTradeFinish")]
        [Validation(Required=false)]
        public string GmtTradeFinish { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [NameInMap("tradeStatus")]
        [Validation(Required=false)]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// 订单优惠金额
        /// </summary>
        [NameInMap("promotionAmount")]
        [Validation(Required=false)]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// 收费金额
        /// </summary>
        [NameInMap("chargeAmount")]
        [Validation(Required=false)]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// 支付渠道明细信息
        /// </summary>
        [NameInMap("payChannelDetailList")]
        [Validation(Required=false)]
        public List<NotifyPayCodePayResultRequestPayChannelDetailList> PayChannelDetailList { get; set; }
        public class NotifyPayCodePayResultRequestPayChannelDetailList : TeaModel {
            /// <summary>
            /// 支付渠道名称
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// 支付渠道类型
            /// </summary>
            [NameInMap("payChannelType")]
            [Validation(Required=false)]
            public string PayChannelType { get; set; }

            /// <summary>
            /// 支付金额
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
            /// 优惠金额
            /// </summary>
            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

            /// <summary>
            /// 资金工具明细
            /// </summary>
            [NameInMap("fundToolDetailList")]
            [Validation(Required=false)]
            public List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> FundToolDetailList { get; set; }
            public class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList : TeaModel {
                /// <summary>
                /// 资金渠道名称
                /// </summary>
                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                /// <summary>
                /// 1.00
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// 结束时间
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
        /// 支付失败错误码
        /// </summary>
        [NameInMap("tradeErrorCode")]
        [Validation(Required=false)]
        public string TradeErrorCode { get; set; }

        /// <summary>
        /// 支付失败信息
        /// </summary>
        [NameInMap("tradeErrorMsg")]
        [Validation(Required=false)]
        public string TradeErrorMsg { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// isvOrgId
        /// </summary>
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        /// <summary>
        /// merchantName
        /// </summary>
        [NameInMap("merchantName")]
        [Validation(Required=false)]
        public string MerchantName { get; set; }

    }

}
