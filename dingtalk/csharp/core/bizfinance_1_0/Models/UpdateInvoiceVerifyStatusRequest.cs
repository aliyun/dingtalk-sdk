// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceVerifyStatusRequest : TeaModel {
        /// <summary>
        /// 抵扣状态
        /// 
        /// </summary>
        [NameInMap("deductStatus")]
        [Validation(Required=false)]
        public string DeductStatus { get; set; }

        /// <summary>
        /// 待更新
        /// </summary>
        [NameInMap("invoiceKeyVOList")]
        [Validation(Required=false)]
        public List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> InvoiceKeyVOList { get; set; }
        public class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList : TeaModel {
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

        }

        /// <summary>
        /// 认证状态
        /// </summary>
        [NameInMap("verifyStatus")]
        [Validation(Required=false)]
        public string VerifyStatus { get; set; }

    }

}
