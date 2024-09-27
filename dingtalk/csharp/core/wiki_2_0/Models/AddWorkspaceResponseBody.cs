// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class AddWorkspaceResponseBody : TeaModel {
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public AddWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class AddWorkspaceResponseBodyWorkspace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_id</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_cover</para>
            /// </summary>
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_create_time</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_creator_id</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public AddWorkspaceResponseBodyWorkspaceIcon Icon { get; set; }
            public class AddWorkspaceResponseBodyWorkspaceIcon : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>icon_url</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_modified_time</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_modifier_id</para>
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>READER</para>
            /// </summary>
            [NameInMap("permissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root_node_uuid</para>
            /// </summary>
            [NameInMap("rootNodeId")]
            [Validation(Required=false)]
            public string RootNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_id</para>
            /// </summary>
            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TEAM</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_url</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace_id</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
