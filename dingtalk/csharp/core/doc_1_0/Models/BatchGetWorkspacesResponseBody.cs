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
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }
                [NameInMap("recentList")]
                [Validation(Required=false)]
                public List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> RecentList { get; set; }
                public class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList : TeaModel {
                    public string NodeId { get; set; }
                    public string Name { get; set; }
                    public string Url { get; set; }
                }
                [NameInMap("orgPublished")]
                [Validation(Required=false)]
                public bool? OrgPublished { get; set; }
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }
            };

        }

    }

}
