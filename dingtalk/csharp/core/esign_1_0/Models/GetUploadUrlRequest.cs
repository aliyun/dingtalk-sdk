// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetUploadUrlRequest : TeaModel {
        [NameInMap("contentMd5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("convert2Pdf")]
        [Validation(Required=false)]
        public bool? Convert2Pdf { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

    }

}
