// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRelatedWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<GetRelatedWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class GetRelatedWorkspacesResponseBodyWorkspaces : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("recentList")]
            [Validation(Required=false)]
            public List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> RecentList { get; set; }
            public class GetRelatedWorkspacesResponseBodyWorkspacesRecentList : TeaModel {
                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
