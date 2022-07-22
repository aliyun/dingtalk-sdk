// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceVoucherStatusRequest : TeaModel {
        /// <summary>
        /// 操作类型
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// 发票编码
        /// </summary>
        [NameInMap("invoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [NameInMap("invoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [NameInMap("voucherId")]
        [Validation(Required=false)]
        public string VoucherId { get; set; }

    }

}
