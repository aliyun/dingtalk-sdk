// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateReceiptVoucherStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("accountPeriod")]
        [Validation(Required=false)]
        public string AccountPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0021241</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("receiptId")]
        [Validation(Required=false)]
        public string ReceiptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("voucherCode")]
        [Validation(Required=false)]
        public string VoucherCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("voucherId")]
        [Validation(Required=false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>记-001</para>
        /// </summary>
        [NameInMap("voucherNo")]
        [Validation(Required=false)]
        public string VoucherNo { get; set; }

    }

}
