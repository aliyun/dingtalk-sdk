// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class UploadVideosResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UploadVideosResponseBodyResult Result { get; set; }
        public class UploadVideosResponseBodyResult : TeaModel {
            [NameInMap("failed")]
            [Validation(Required=false)]
            public List<string> Failed { get; set; }

            [NameInMap("hasUploaded")]
            [Validation(Required=false)]
            public long? HasUploaded { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public long? Success { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
