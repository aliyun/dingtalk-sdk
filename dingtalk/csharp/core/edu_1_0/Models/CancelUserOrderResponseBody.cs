// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CancelUserOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123400</para>
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M000001</para>
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CM0001234</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("payStatus")]
        [Validation(Required=false)]
        public int? PayStatus { get; set; }

        [NameInMap("refundStatus")]
        [Validation(Required=false)]
        public int? RefundStatus { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public long? TotalAmount { get; set; }

    }

}
