// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyNodes> Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIDOC</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_create_time</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_creator_id</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adoc</para>
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_modified_time</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_modifier_id</para>
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_id</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>READER</para>
            /// </summary>
            [NameInMap("permissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("statisticalInfo")]
            [Validation(Required=false)]
            public ListNodesResponseBodyNodesStatisticalInfo StatisticalInfo { get; set; }
            public class ListNodesResponseBodyNodesStatisticalInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("wordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_url</para>
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
