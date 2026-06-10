// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class ListWorkflowsResponseBody : TeaModel {
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("workflows")]
        [Validation(Required=false)]
        public List<ListWorkflowsResponseBodyWorkflows> Workflows { get; set; }
        public class ListWorkflowsResponseBodyWorkflows : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("flowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
