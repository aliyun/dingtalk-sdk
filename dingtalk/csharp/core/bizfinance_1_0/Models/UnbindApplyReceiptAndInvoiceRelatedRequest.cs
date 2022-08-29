// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UnbindApplyReceiptAndInvoiceRelatedRequest : TeaModel {
        /// <summary>
        /// 审批单id
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 发票模型
        /// </summary>
        [NameInMap("invoiceKeyVOList")]
        [Validation(Required=false)]
        public List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
        public class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList : TeaModel {
            /// <summary>
            /// 发票代码
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

        }

        /// <summary>
        /// 操作员
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
