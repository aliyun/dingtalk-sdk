// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class DeleteReceiptRequest : TeaModel {
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<DeleteReceiptRequestReceipts> Receipts { get; set; }
        public class DeleteReceiptRequestReceipts : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("deleteUserId")]
            [Validation(Required=false)]
            public string DeleteUserId { get; set; }

            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

        }

    }

}
