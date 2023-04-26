// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserWatchLiveListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserWatchLiveListResponseBodyResult Result { get; set; }
        public class GetUserWatchLiveListResponseBodyResult : TeaModel {
            [NameInMap("hasFinish")]
            [Validation(Required=false)]
            public bool? HasFinish { get; set; }

            [NameInMap("liveInfoPopModelList")]
            [Validation(Required=false)]
            public List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> LiveInfoPopModelList { get; set; }
            public class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList : TeaModel {
                [NameInMap("extraInfo")]
                [Validation(Required=false)]
                public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo ExtraInfo { get; set; }
                public class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo : TeaModel {
                    [NameInMap("hasSubscribed")]
                    [Validation(Required=false)]
                    public bool? HasSubscribed { get; set; }

                    [NameInMap("isForecastExpired")]
                    [Validation(Required=false)]
                    public bool? IsForecastExpired { get; set; }

                    [NameInMap("watchProgressMs")]
                    [Validation(Required=false)]
                    public long? WatchProgressMs { get; set; }

                }

                [NameInMap("liveBasicInfo")]
                [Validation(Required=false)]
                public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo LiveBasicInfo { get; set; }
                public class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo : TeaModel {
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

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
