// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryAttachmentResponseBody : TeaModel {
        [NameInMap("attachmentList")]
        [Validation(Required=false)]
        public List<QueryAttachmentResponseBodyAttachmentList> AttachmentList { get; set; }
        public class QueryAttachmentResponseBodyAttachmentList : TeaModel {
            [NameInMap("attachmentType")]
            [Validation(Required=false)]
            public string AttachmentType { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
