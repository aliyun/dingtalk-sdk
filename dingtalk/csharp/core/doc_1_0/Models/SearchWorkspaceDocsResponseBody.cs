// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SearchWorkspaceDocsResponseBody : TeaModel {
        [NameInMap("docs")]
        [Validation(Required=false)]
        public List<SearchWorkspaceDocsResponseBodyDocs> Docs { get; set; }
        public class SearchWorkspaceDocsResponseBodyDocs : TeaModel {
            [NameInMap("nodeBO")]
            [Validation(Required=false)]
            public SearchWorkspaceDocsResponseBodyDocsNodeBO NodeBO { get; set; }
            public class SearchWorkspaceDocsResponseBodyDocsNodeBO : TeaModel {
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

                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("workspaceBO")]
            [Validation(Required=false)]
            public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO WorkspaceBO { get; set; }
            public class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
