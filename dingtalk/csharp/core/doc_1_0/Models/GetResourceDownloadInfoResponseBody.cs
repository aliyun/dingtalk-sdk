// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetResourceDownloadInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetResourceDownloadInfoResponseBodyResult Result { get; set; }
        public class GetResourceDownloadInfoResponseBodyResult : TeaModel {
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
