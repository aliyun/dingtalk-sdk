// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SearchWorkspaceDocsResponseBody : TeaModel {
        [NameInMap("docs")]
        [Validation(Required=false)]
        public List<SearchWorkspaceDocsResponseBodyDocs> Docs { get; set; }
        public class SearchWorkspaceDocsResponseBodyDocs : TeaModel {
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public SearchWorkspaceDocsResponseBodyDocsNodeBO NodeBO { get; set; }
            public class SearchWorkspaceDocsResponseBodyDocsNodeBO : TeaModel {
                /// <summary>
                /// 节点类型
                /// </summary>
                [NameInMap("docType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                /// <summary>
                /// 最近编辑时间
                /// </summary>
                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// 节点名称，如果命中了搜索关键词会包含高亮标签
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 节点Id
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// 节点原始名称
                /// </summary>
                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                /// <summary>
                /// 节点打开url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO WorkspaceBO { get; set; }
            public class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO : TeaModel {
                /// <summary>
                /// 团队空间名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 团队空间Id
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

        /// <summary>
        /// 是否还有可搜索内容
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
