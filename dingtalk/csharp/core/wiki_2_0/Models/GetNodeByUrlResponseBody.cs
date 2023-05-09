// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class GetNodeByUrlResponseBody : TeaModel {
        [NameInMap("node")]
        [Validation(Required=false)]
        public GetNodeByUrlResponseBodyNode Node { get; set; }
        public class GetNodeByUrlResponseBodyNode : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("hasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("permissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("statisticalInfo")]
            [Validation(Required=false)]
            public GetNodeByUrlResponseBodyNodeStatisticalInfo StatisticalInfo { get; set; }
            public class GetNodeByUrlResponseBodyNodeStatisticalInfo : TeaModel {
                [NameInMap("wordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
