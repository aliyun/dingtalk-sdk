// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRecentOpenDocsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [NameInMap("recentList")]
        [Validation(Required=false)]
        public List<GetRecentOpenDocsResponseBodyRecentList> RecentList { get; set; }
        public class GetRecentOpenDocsResponseBodyRecentList : TeaModel {
            /// <summary>
            /// 文档信息
            /// </summary>
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public GetRecentOpenDocsResponseBodyRecentListNodeBO NodeBO { get; set; }
            public class GetRecentOpenDocsResponseBodyRecentListNodeBO : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }
                [NameInMap("docType")]
                [Validation(Required=false)]
                public string DocType { get; set; }
                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }
                [NameInMap("lastOpenTime")]
                [Validation(Required=false)]
                public long? LastOpenTime { get; set; }
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }
            };

            /// <summary>
            /// 团队空间信息
            /// </summary>
            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO WorkspaceBO { get; set; }
            public class GetRecentOpenDocsResponseBodyRecentListWorkspaceBO : TeaModel {
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("workspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }
            };

        }

    }

}
