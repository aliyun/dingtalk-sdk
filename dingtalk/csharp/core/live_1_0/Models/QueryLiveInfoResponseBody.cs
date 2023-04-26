// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveInfoResponseBodyResult Result { get; set; }
        public class QueryLiveInfoResponseBodyResult : TeaModel {
            [NameInMap("liveInfo")]
            [Validation(Required=false)]
            public QueryLiveInfoResponseBodyResultLiveInfo LiveInfo { get; set; }
            public class QueryLiveInfoResponseBodyResultLiveInfo : TeaModel {
                [NameInMap("coverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                [NameInMap("liveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                [NameInMap("livePlayUrl")]
                [Validation(Required=false)]
                public string LivePlayUrl { get; set; }

                [NameInMap("liveStatus")]
                [Validation(Required=false)]
                public int? LiveStatus { get; set; }

                [NameInMap("playbackDuration")]
                [Validation(Required=false)]
                public long? PlaybackDuration { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("subscribeCount")]
                [Validation(Required=false)]
                public int? SubscribeCount { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("uv")]
                [Validation(Required=false)]
                public int? Uv { get; set; }

            }

        }

    }

}
