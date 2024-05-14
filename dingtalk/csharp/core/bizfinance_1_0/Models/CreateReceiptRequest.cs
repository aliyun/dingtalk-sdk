// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class CreateReceiptRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<CreateReceiptRequestReceipts> Receipts { get; set; }
        public class CreateReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            [NameInMap("customerCode")]
            [Validation(Required=false)]
            public string CustomerCode { get; set; }

            [NameInMap("enterpriseAcountCode")]
            [Validation(Required=false)]
            public string EnterpriseAcountCode { get; set; }

            [NameInMap("occurDate")]
            [Validation(Required=false)]
            public long? OccurDate { get; set; }

            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("supplierCode")]
            [Validation(Required=false)]
            public string SupplierCode { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
