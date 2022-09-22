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
                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// 节点类型
                /// </summary>
                [NameInMap("docType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                /// <summary>
                /// 是否被删除
                /// </summary>
                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// 内容的最后编辑时间
                /// </summary>
                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// 文档Id
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// 文档名称
                /// </summary>
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// 文档更新时间，包括重命名、移动、内容编辑等操作都会刷新更新时间
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// 文档打开url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 知识库信息。
            /// </summary>
            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public GetRecentEditDocsResponseBodyRecentListWorkspaceBO WorkspaceBO { get; set; }
            public class GetRecentEditDocsResponseBodyRecentListWorkspaceBO : TeaModel {
                /// <summary>
                /// 知识库打开url。
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// 知识库id。
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// 知识库名称。
                /// </summary>
                [NameInMap("workspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

    }

}
