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

        [NameInMap("recentList")]
        [Validation(Required=false)]
        public List<GetRecentEditDocsResponseBodyRecentList> RecentList { get; set; }
        public class GetRecentEditDocsResponseBodyRecentList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public GetRecentEditDocsResponseBodyRecentListNodeBO NodeBO { get; set; }
            public class GetRecentEditDocsResponseBodyRecentListNodeBO : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("docType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public GetRecentEditDocsResponseBodyRecentListWorkspaceBO WorkspaceBO { get; set; }
            public class GetRecentEditDocsResponseBodyRecentListWorkspaceBO : TeaModel {
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("workspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

    }

}
