// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetOrgLiveListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOrgLiveListResponseBodyResult Result { get; set; }
        public class GetOrgLiveListResponseBodyResult : TeaModel {
            [NameInMap("newLive")]
            [Validation(Required=false)]
            public GetOrgLiveListResponseBodyResultNewLive NewLive { get; set; }
            public class GetOrgLiveListResponseBodyResultNewLive : TeaModel {
                [NameInMap("hasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("liveList")]
                [Validation(Required=false)]
                public List<GetOrgLiveListResponseBodyResultNewLiveLiveList> LiveList { get; set; }
                public class GetOrgLiveListResponseBodyResultNewLiveLiveList : TeaModel {
                    [NameInMap("anchorNickname")]
                    [Validation(Required=false)]
                    public string AnchorNickname { get; set; }

                    [NameInMap("anchorUnionId")]
                    [Validation(Required=false)]
                    public string AnchorUnionId { get; set; }

                    [NameInMap("liveEndTime")]
                    [Validation(Required=false)]
                    public long? LiveEndTime { get; set; }

                    [NameInMap("liveStartTime")]
                    [Validation(Required=false)]
                    public long? LiveStartTime { get; set; }

                    [NameInMap("liveUuid")]
                    [Validation(Required=false)]
                    public string LiveUuid { get; set; }

                    [NameInMap("shareOpenConversationIds")]
                    [Validation(Required=false)]
                    public List<string> ShareOpenConversationIds { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("updateLive")]
            [Validation(Required=false)]
            public GetOrgLiveListResponseBodyResultUpdateLive UpdateLive { get; set; }
            public class GetOrgLiveListResponseBodyResultUpdateLive : TeaModel {
                [NameInMap("hasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("liveList")]
                [Validation(Required=false)]
                public List<GetOrgLiveListResponseBodyResultUpdateLiveLiveList> LiveList { get; set; }
                public class GetOrgLiveListResponseBodyResultUpdateLiveLiveList : TeaModel {
                    [NameInMap("anchorNickname")]
                    [Validation(Required=false)]
                    public string AnchorNickname { get; set; }

                    [NameInMap("anchorUnionId")]
                    [Validation(Required=false)]
                    public string AnchorUnionId { get; set; }

                    [NameInMap("liveEndTime")]
                    [Validation(Required=false)]
                    public long? LiveEndTime { get; set; }

                    [NameInMap("liveStartTime")]
                    [Validation(Required=false)]
                    public long? LiveStartTime { get; set; }

                    [NameInMap("liveUuid")]
                    [Validation(Required=false)]
                    public string LiveUuid { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

    }

}
