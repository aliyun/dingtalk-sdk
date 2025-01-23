// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryMinutesPlayInfoResponseBody : TeaModel {
        [NameInMap("playInfo")]
        [Validation(Required=false)]
        public QueryMinutesPlayInfoResponseBodyPlayInfo PlayInfo { get; set; }
        public class QueryMinutesPlayInfoResponseBodyPlayInfo : TeaModel {
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("mediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            [NameInMap("playUrl")]
            [Validation(Required=false)]
            public string PlayUrl { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
