// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryAppFunctionNodesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryAppFunctionNodesResponseBodyData> Data { get; set; }
        public class QueryAppFunctionNodesResponseBodyData : TeaModel {
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("isSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("nodeVisibleType")]
            [Validation(Required=false)]
            public string NodeVisibleType { get; set; }

            [NameInMap("parentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
