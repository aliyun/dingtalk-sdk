// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRelatedWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// 团队空间结果集
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<GetRelatedWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class GetRelatedWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// 团队空间Id
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// 团队空间打开url
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// 团队空间是否被删除
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// 团队空间名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 团队空间最近访问文档列表
            /// </summary>
            [NameInMap("recentList")]
            [Validation(Required=false)]
            public List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> RecentList { get; set; }
            public class GetRelatedWorkspacesResponseBodyWorkspacesRecentList : TeaModel {
                /// <summary>
                /// 文档id
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// 文档名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 文档打开url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 团队空间创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

        }

    }

}
