// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserCreateLiveListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserCreateLiveListResponseBodyResult Result { get; set; }
        public class GetUserCreateLiveListResponseBodyResult : TeaModel {
            [NameInMap("hasFinish")]
            [Validation(Required=false)]
            public bool? HasFinish { get; set; }
            [NameInMap("liveInfoPopModelList")]
            [Validation(Required=false)]
            public List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> LiveInfoPopModelList { get; set; }
            public class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList : TeaModel {
                public string CoverUrl { get; set; }
                public long? Duration { get; set; }
                public long? EndTime { get; set; }
                public string Introduction { get; set; }
                public string LiveId { get; set; }
                public string LivePlayUrl { get; set; }
                public int? LiveStatus { get; set; }
                public long? StartTime { get; set; }
                public int? SubscribeCount { get; set; }
                public string Title { get; set; }
                public string UnionId { get; set; }
                public int? Uv { get; set; }
            }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

    }

}