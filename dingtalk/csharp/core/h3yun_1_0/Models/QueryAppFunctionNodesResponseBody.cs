// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryAppFunctionNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryAppFunctionNodesResponseBodyData> Data { get; set; }
        public class QueryAppFunctionNodesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>D000001</para>
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>客户管理</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FormModule</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AllVisible</para>
            /// </summary>
            [NameInMap("nodeVisibleType")]
            [Validation(Required=false)]
            public string NodeVisibleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6b42e223-c849-4fe9-9916-52f52d1a41b5</para>
            /// </summary>
            [NameInMap("parentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8d56c3b7-e996-4223-96a0-85ad16c11825</para>
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000011</para>
            /// </summary>
            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
