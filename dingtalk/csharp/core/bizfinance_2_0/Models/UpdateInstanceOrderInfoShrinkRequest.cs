// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateInstanceOrderInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx错误</para>
        /// </summary>
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("outOrderNo")]
        [Validation(Required=false)]
        public string OutOrderNo { get; set; }

        [NameInMap("payerBank")]
        [Validation(Required=false)]
        public string PayerBankShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1709691000682</para>
        /// </summary>
        [NameInMap("paymentTime")]
        [Validation(Required=false)]
        public long? PaymentTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAYING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
