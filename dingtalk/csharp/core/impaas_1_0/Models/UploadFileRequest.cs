// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class UploadFileRequest : TeaModel {
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("senderUid")]
        [Validation(Required=false)]
        public string SenderUid { get; set; }

    }

}
