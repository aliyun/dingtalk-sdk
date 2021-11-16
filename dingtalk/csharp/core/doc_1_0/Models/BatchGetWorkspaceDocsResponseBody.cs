// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchGetWorkspaceDocsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetWorkspaceDocsResponseBodyResult> Result { get; set; }
        public class BatchGetWorkspaceDocsResponseBodyResult : TeaModel {
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public BatchGetWorkspaceDocsResponseBodyResultNodeBO NodeBO { get; set; }
            public class BatchGetWorkspaceDocsResponseBodyResultNodeBO : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }
                [NameInMap("deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }
            };

            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO WorkspaceBO { get; set; }
            public class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO : TeaModel {
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("hasPermission")]
            [Validation(Required=false)]
            public bool? HasPermission { get; set; }

        }

    }

}
