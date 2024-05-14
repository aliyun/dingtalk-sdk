// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class DeleteReceiptRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<DeleteReceiptRequestReceipts> Receipts { get; set; }
        public class DeleteReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deleteUserId")]
            [Validation(Required=false)]
            public string DeleteUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

        }

    }

}
