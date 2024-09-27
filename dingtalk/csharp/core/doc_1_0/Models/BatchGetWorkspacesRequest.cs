// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchGetWorkspacesRequest : TeaModel {
        [NameInMap("includeRecent")]
        [Validation(Required=false)]
        public bool? IncludeRecent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

    }

}
