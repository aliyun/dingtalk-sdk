// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GrantProcessInstanceForDownloadFileResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GrantProcessInstanceForDownloadFileResponseBodyResult Result { get; set; }
        public class GrantProcessInstanceForDownloadFileResponseBodyResult : TeaModel {
            [NameInMap("downloadUri")]
            [Validation(Required=false)]
            public string DownloadUri { get; set; }

            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
