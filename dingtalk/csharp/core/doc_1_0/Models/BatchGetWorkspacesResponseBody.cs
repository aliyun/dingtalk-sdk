// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchGetWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// workspace信息
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<BatchGetWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class BatchGetWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// 是否有访问团队空间权限
            /// </summary>
            [NameInMap("hasPermission")]
            [Validation(Required=false)]
            public bool? HasPermission { get; set; }

            /// <summary>
            /// 团队空间信息
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public BatchGetWorkspacesResponseBodyWorkspacesWorkspace Workspace { get; set; }
            public class BatchGetWorkspacesResponseBodyWorkspacesWorkspace : TeaModel {
                /// <summary>
                /// 团队空间创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// 团队空间名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 是否全员公开
                /// </summary>
                [NameInMap("orgPublished")]
                [Validation(Required=false)]
                public bool? OrgPublished { get; set; }

                /// <summary>
                /// 最近访问列表
                /// </summary>
                [NameInMap("recentList")]
                [Validation(Required=false)]
                public List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> RecentList { get; set; }
                public class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList : TeaModel {
                    /// <summary>
                    /// 最近编辑时间
                    /// </summary>
                    [NameInMap("lastEditTime")]
                    [Validation(Required=false)]
                    public string LastEditTime { get; set; }

                    /// <summary>
                    /// 文档名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 文档Id
                    /// </summary>
                    [NameInMap("nodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// 文档打开url
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// 团队空间打开url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// 团队空间Id
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

    }

}
