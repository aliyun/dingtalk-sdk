// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRelatedWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<GetRelatedWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class GetRelatedWorkspacesResponseBodyWorkspaces : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OWNER：所有者；MANAGER：管理者；EDITOR：可编辑；VIEWER：可查询\下载；ONLY_VIEWER：尽可查看</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
