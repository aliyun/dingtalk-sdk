// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyPayCodeRefundResultRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-11 11:11:11</para>
        /// </summary>
        [NameInMap("gmtRefund")]
        [Validation(Required=false)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("payChannelDetailList")]
        [Validation(Required=false)]
        public List<NotifyPayCodeRefundResultRequestPayChannelDetailList> PayChannelDetailList { get; set; }
        public class NotifyPayCodeRefundResultRequestPayChannelDetailList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fundToolDetailList")]
            [Validation(Required=false)]
            public List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> FundToolDetailList { get; set; }
            public class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.00</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>余额</para>
                /// </summary>
                [NameInMap("fundToolName")]
                [Validation(Required=false)]
                public string FundToolName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-31 11:11:11</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-31 11:11:11</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210531123456</para>
            /// </summary>
            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021053112345678</para>
            /// </summary>
            [NameInMap("payChannelRefundOrderNo")]
            [Validation(Required=false)]
            public string PayChannelRefundOrderNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
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
        /// <para>payCode</para>
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.00</para>
        /// </summary>
        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refundOrderNo</para>
        /// </summary>
        [NameInMap("refundOrderNo")]
        [Validation(Required=false)]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00</para>
        /// </summary>
        [NameInMap("refundPromotionAmount")]
        [Validation(Required=false)]
        public string RefundPromotionAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>晚餐退款</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tradeNo</para>
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userId</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
