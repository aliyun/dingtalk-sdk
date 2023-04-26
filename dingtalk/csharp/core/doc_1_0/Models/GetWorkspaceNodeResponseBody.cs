// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetWorkspaceNodeResponseBody : TeaModel {
        [NameInMap("hasPermission")]
        [Validation(Required=false)]
        public bool? HasPermission { get; set; }

        [NameInMap("nodeBO")]
        [Validation(Required=false)]
        public GetWorkspaceNodeResponseBodyNodeBO NodeBO { get; set; }
        public class GetWorkspaceNodeResponseBodyNodeBO : TeaModel {
            [NameInMap("docType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            [NameInMap("lastEditTime")]
            [Validation(Required=false)]
            public long? LastEditTime { get; set; }

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

        [NameInMap("workspaceBO")]
        [Validation(Required=false)]
        public GetWorkspaceNodeResponseBodyWorkspaceBO WorkspaceBO { get; set; }
        public class GetWorkspaceNodeResponseBodyWorkspaceBO : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
