// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAccountingStatusRequest : TeaModel {
        /// <summary>
        /// 发票财务模型列表
        /// </summary>
        [NameInMap("invoiceFinanceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList> InvoiceFinanceInfoVOList { get; set; }
        public class UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList : TeaModel {
            /// <summary>
            /// 入账状态
            /// </summary>
            [NameInMap("accountingStatus")]
            [Validation(Required=false)]
            public string AccountingStatus { get; set; }

            /// <summary>
            /// 发票号码
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// 发票代码
            /// </summary>
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// 发票类型
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

        }

    }

}
