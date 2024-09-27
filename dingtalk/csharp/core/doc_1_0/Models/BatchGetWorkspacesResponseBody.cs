// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchGetWorkspacesResponseBody : TeaModel {
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<BatchGetWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class BatchGetWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hasPermission")]
            [Validation(Required=false)]
            public bool? HasPermission { get; set; }

            [NameInMap("workspace")]
            [Validation(Required=false)]
            public BatchGetWorkspacesResponseBodyWorkspacesWorkspace Workspace { get; set; }
            public class BatchGetWorkspacesResponseBodyWorkspacesWorkspace : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("orgPublished")]
                [Validation(Required=false)]
                public bool? OrgPublished { get; set; }

                [NameInMap("recentList")]
                [Validation(Required=false)]
                public List<BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList> RecentList { get; set; }
                public class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList : TeaModel {
                    [NameInMap("lastEditTime")]
                    [Validation(Required=false)]
                    public string LastEditTime { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

    }

}
