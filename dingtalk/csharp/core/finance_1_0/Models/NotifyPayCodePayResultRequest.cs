// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyPayCodePayResultRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234.56</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.00, 没有传0.00</para>
        /// </summary>
        [NameInMap("chargeAmount")]
        [Validation(Required=false)]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding1234</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;akey&quot;: &quot;avalue“}</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 11:11:11</para>
        /// </summary>
        [NameInMap("gmtTradeCreate")]
        [Validation(Required=false)]
        public string GmtTradeCreate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 11:11:11</para>
        /// </summary>
        [NameInMap("gmtTradeFinish")]
        [Validation(Required=false)]
        public string GmtTradeFinish { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX公司食堂</para>
        /// </summary>
        [NameInMap("merchantName")]
        [Validation(Required=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("payChannelDetailList")]
        [Validation(Required=false)]
        public List<NotifyPayCodePayResultRequestPayChannelDetailList> PayChannelDetailList { get; set; }
        public class NotifyPayCodePayResultRequestPayChannelDetailList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.23</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fundToolDetailList")]
            [Validation(Required=false)]
            public List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> FundToolDetailList { get; set; }
            public class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>金额</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>优惠券</para>
                /// </summary>
                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01 11:11:11</para>
                /// </summary>
                [NameInMap("gmtFinish")]
                [Validation(Required=false)]
                public string GmtFinish { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("promotionFundTool")]
                [Validation(Required=false)]
                public bool? PromotionFundTool { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01 11:11:11</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01 11:11:11</para>
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>卡余额</para>
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20211234</para>
            /// </summary>
            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY|BALANCE</para>
            /// </summary>
            [NameInMap("payChannelType")]
            [Validation(Required=false)]
            public string PayChannelType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00</para>
            /// </summary>
            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>261234567890</para>
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.23，没有传0.00</para>
        /// </summary>
        [NameInMap("promotionAmount")]
        [Validation(Required=false)]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>晚餐100.0元</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BALANCE_NOT_ENOUGH</para>
        /// </summary>
        [NameInMap("tradeErrorCode")]
        [Validation(Required=false)]
        public string TradeErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>余额不足，请充值</para>
        /// </summary>
        [NameInMap("tradeErrorMsg")]
        [Validation(Required=false)]
        public string TradeErrorMsg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202101012345678</para>
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS/FAIL</para>
        /// </summary>
        [NameInMap("tradeStatus")]
        [Validation(Required=false)]
        public string TradeStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userId1234</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
