// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetImageTempDownloadUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetImageTempDownloadUrlResponseBodyResult Result { get; set; }
        public class GetImageTempDownloadUrlResponseBodyResult : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
