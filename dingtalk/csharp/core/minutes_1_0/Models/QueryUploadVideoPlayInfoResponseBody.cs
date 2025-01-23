// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryUploadVideoPlayInfoResponseBody : TeaModel {
        [NameInMap("playInfo")]
        [Validation(Required=false)]
        public QueryUploadVideoPlayInfoResponseBodyPlayInfo PlayInfo { get; set; }
        public class QueryUploadVideoPlayInfoResponseBodyPlayInfo : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("playUrl")]
            [Validation(Required=false)]
            public string PlayUrl { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
