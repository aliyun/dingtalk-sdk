// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRecentEditDocsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [NameInMap("recentList")]
        [Validation(Required=false)]
        public List<GetRecentEditDocsResponseBodyRecentList> RecentList { get; set; }
        public class GetRecentEditDocsResponseBodyRecentList : TeaModel {
            /// <summary>
            /// 文档信息
            /// </summary>
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public GetRecentEditDocsResponseBodyRecentListNodeBO NodeBO { get; set; }
            public class GetRecentEditDocsResponseBodyRecentListNodeBO : TeaModel {
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }
                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }
                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }
            };

            /// <summary>
            /// 团队空间信息
            /// </summary>
            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public GetRecentEditDocsResponseBodyRecentListWorkspaceBO WorkspaceBO { get; set; }
            public class GetRecentEditDocsResponseBodyRecentListWorkspaceBO : TeaModel {
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
