// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyPayCodePayResultRequest : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("chargeAmount")]
        [Validation(Required=false)]
        public string ChargeAmount { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("gmtTradeCreate")]
        [Validation(Required=false)]
        public string GmtTradeCreate { get; set; }

        [NameInMap("gmtTradeFinish")]
        [Validation(Required=false)]
        public string GmtTradeFinish { get; set; }

        [NameInMap("merchantName")]
        [Validation(Required=false)]
        public string MerchantName { get; set; }

        [NameInMap("payChannelDetailList")]
        [Validation(Required=false)]
        public List<NotifyPayCodePayResultRequestPayChannelDetailList> PayChannelDetailList { get; set; }
        public class NotifyPayCodePayResultRequestPayChannelDetailList : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("fundToolDetailList")]
            [Validation(Required=false)]
            public List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> FundToolDetailList { get; set; }
            public class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtFinish")]
                [Validation(Required=false)]
                public string GmtFinish { get; set; }

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

            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

            [NameInMap("payChannelType")]
            [Validation(Required=false)]
            public string PayChannelType { get; set; }

            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

        }

        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        [NameInMap("promotionAmount")]
        [Validation(Required=false)]
        public string PromotionAmount { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("tradeErrorCode")]
        [Validation(Required=false)]
        public string TradeErrorCode { get; set; }

        [NameInMap("tradeErrorMsg")]
        [Validation(Required=false)]
        public string TradeErrorMsg { get; set; }

        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        [NameInMap("tradeStatus")]
        [Validation(Required=false)]
        public string TradeStatus { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
