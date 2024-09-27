// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreatWithholdingOrderAndPayRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.01</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202111090001</para>
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("otherPayChannelDetailInfoList")]
        [Validation(Required=false)]
        public List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> OtherPayChannelDetailInfoList { get; set; }
        public class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.00</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fundToolDetailInfoList")]
            [Validation(Required=false)]
            public List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> FundToolDetailInfoList { get; set; }
            public class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.00</para>
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
                /// <para>2021-11-15 10:10:10</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-15 10:10:11</para>
                /// </summary>
                [NameInMap("gmtFinish")]
                [Validation(Required=false)]
                public string GmtFinish { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("promotionFundTool")]
                [Validation(Required=false)]
                public bool? PromotionFundTool { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>支付宝</para>
            /// </summary>
            [NameInMap("payChannelName")]
            [Validation(Required=false)]
            public string PayChannelName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021110100001</para>
            /// </summary>
            [NameInMap("payChannelOrderNo")]
            [Validation(Required=false)]
            public string PayChannelOrderNo { get; set; }

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
            /// <para>4.00</para>
            /// </summary>
            [NameInMap("promotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021113000001</para>
        /// </summary>
        [NameInMap("outTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIPAY</para>
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2120493284</para>
        /// </summary>
        [NameInMap("payerUserId")]
        [Validation(Required=false)]
        public string PayerUserId { get; set; }

        /// <summary>
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
        /// <para>1001</para>
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15m</para>
        /// </summary>
        [NameInMap("timeOutExpress")]
        [Validation(Required=false)]
        public string TimeOutExpress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>餐费</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
