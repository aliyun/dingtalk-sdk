// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveWatchUserListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveWatchUserListResponseBodyResult Result { get; set; }
        public class QueryLiveWatchUserListResponseBodyResult : TeaModel {
            [NameInMap("orgUsesList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> OrgUsesList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOrgUsesList : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

            [NameInMap("outOrgUserList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> OutOrgUserList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOutOrgUserList : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

        }

    }

}
