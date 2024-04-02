// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BatchSyncBankReceiptRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<BatchSyncBankReceiptRequestBody> Body { get; set; }
        public class BatchSyncBankReceiptRequestBody : TeaModel {
            [NameInMap("fileDownloadUrl")]
            [Validation(Required=false)]
            public string FileDownloadUrl { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("messageIdType")]
            [Validation(Required=false)]
            public string MessageIdType { get; set; }

        }

    }

}
