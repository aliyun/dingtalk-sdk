// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class HandOverWorkspaceRequest : TeaModel {
        [NameInMap("sourceOwnerId")]
        [Validation(Required=false)]
        public string SourceOwnerId { get; set; }

        [NameInMap("targetOwnerId")]
        [Validation(Required=false)]
        public string TargetOwnerId { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
