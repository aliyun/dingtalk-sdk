// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class NotifyBadgeCodePayResultRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("chargeAmount")]
        [Validation(Required=false)]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtTradeCreate")]
        [Validation(Required=false)]
        public string GmtTradeCreate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtTradeFinish")]
        [Validation(Required=false)]
        public string GmtTradeFinish { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("merchantName")]
        [Validation(Required=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payChannelDetailList")]
        [Validation(Required=false)]
        public List<NotifyBadgeCodePayResultRequestPayChannelDetailList> PayChannelDetailList { get; set; }
        public class NotifyBadgeCodePayResultRequestPayChannelDetailList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fundToolDetailList")]
            [Validation(Required=false)]
            public List<NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList> FundToolDetailList { get; set; }
            public class NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("gmtFinish")]
                [Validation(Required=false)]
                public string GmtFinish { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("promotionFundTool")]
                [Validation(Required=false)]
                public bool? PromotionFundTool { get; set; }

            }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("payChannelType")]
            [Validation(Required=false)]
            public string PayChannelType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("promotionAmount")]
        [Validation(Required=false)]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("tradeErrorCode")]
        [Validation(Required=false)]
        public string TradeErrorCode { get; set; }

        [NameInMap("tradeErrorMsg")]
        [Validation(Required=false)]
        public string TradeErrorMsg { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tradeStatus")]
        [Validation(Required=false)]
        public string TradeStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
