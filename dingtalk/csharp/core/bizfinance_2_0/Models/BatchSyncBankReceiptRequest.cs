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
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxx">https://xxxxx</a></para>
            /// </summary>
            [NameInMap("fileDownloadUrl")]
            [Validation(Required=false)]
            public string FileDownloadUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx回单.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024000001902335</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>detailId</para>
            /// </summary>
            [NameInMap("messageIdType")]
            [Validation(Required=false)]
            public string MessageIdType { get; set; }

        }

    }

}
