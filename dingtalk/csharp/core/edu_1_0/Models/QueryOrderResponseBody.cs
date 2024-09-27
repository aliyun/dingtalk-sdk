// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrderResponseBody : TeaModel {
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123400</para>
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-04T17:15Z</para>
        /// </summary>
        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public string CloseTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672973971107</para>
        /// </summary>
        [NameInMap("closeTimestamp")]
        [Validation(Required=false)]
        public long? CloseTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-04T17:15Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672973971107</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M20000100</para>
        /// </summary>
        [NameInMap("merchantMergeOrderNo")]
        [Validation(Required=false)]
        public string MerchantMergeOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M20000100</para>
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CM0001</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fagweefdsdgfa</para>
        /// </summary>
        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>138***</para>
        /// </summary>
        [NameInMap("payLogonId")]
        [Validation(Required=false)]
        public string PayLogonId { get; set; }

        [NameInMap("payStatus")]
        [Validation(Required=false)]
        public int? PayStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-04T17:15Z</para>
        /// </summary>
        [NameInMap("payTime")]
        [Validation(Required=false)]
        public string PayTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672973971107</para>
        /// </summary>
        [NameInMap("payTimestamp")]
        [Validation(Required=false)]
        public long? PayTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("payType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public long? RefundAmount { get; set; }

        [NameInMap("refundStatus")]
        [Validation(Required=false)]
        public int? RefundStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-04T17:15Z</para>
        /// </summary>
        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public string RefundTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672973971107</para>
        /// </summary>
        [NameInMap("refundTimestamp")]
        [Validation(Required=false)]
        public long? RefundTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>教育产品</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022080311111</para>
        /// </summary>
        [NameInMap("tradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}
