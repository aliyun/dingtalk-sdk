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
                public string DeptName { get; set; }
                public string Name { get; set; }
                public string UnionId { get; set; }
                public string UserId { get; set; }
                public long? WatchLiveTime { get; set; }
                public long? WatchPlaybackTime { get; set; }
                public long? WatchProgressMs { get; set; }
            }
            [NameInMap("outOrgUserList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> OutOrgUserList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOutOrgUserList : TeaModel {
                public string Name { get; set; }
                public long? WatchLiveTime { get; set; }
                public long? WatchPlaybackTime { get; set; }
                public long? WatchProgressMs { get; set; }
            }
        };

    }

}
