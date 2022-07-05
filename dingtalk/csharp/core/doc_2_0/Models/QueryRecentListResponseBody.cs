// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryRecentListResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 分页游标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 子节点列表。
        /// </summary>
        [NameInMap("recentList")]
        [Validation(Required=false)]
        public List<QueryRecentListResponseBodyRecentList> RecentList { get; set; }
        public class QueryRecentListResponseBodyRecentList : TeaModel {
            /// <summary>
            /// 是否被删除。
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// 节点信息。
            /// </summary>
            [NameInMap("dentry")]
            [Validation(Required=false)]
            public DentryModel Dentry { get; set; }

            /// <summary>
            /// 如果查询的是访问，那么这里是访问时间；否则就是编辑时间。
            /// </summary>
            [NameInMap("recentTime")]
            [Validation(Required=false)]
            public long? RecentTime { get; set; }

        }

    }

}
