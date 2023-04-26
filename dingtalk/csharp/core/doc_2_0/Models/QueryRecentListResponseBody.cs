// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryRecentListResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("recentList")]
        [Validation(Required=false)]
        public List<QueryRecentListResponseBodyRecentList> RecentList { get; set; }
        public class QueryRecentListResponseBodyRecentList : TeaModel {
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("dentry")]
            [Validation(Required=false)]
            public DentryModel Dentry { get; set; }

            [NameInMap("recentTime")]
            [Validation(Required=false)]
            public long? RecentTime { get; set; }

            [NameInMap("team")]
            [Validation(Required=false)]
            public QueryRecentListResponseBodyRecentListTeam Team { get; set; }
            public class QueryRecentListResponseBodyRecentListTeam : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
