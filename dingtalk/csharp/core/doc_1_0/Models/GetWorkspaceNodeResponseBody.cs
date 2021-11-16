// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetWorkspaceNodeResponseBody : TeaModel {
        /// <summary>
        /// 是否有权限
        /// </summary>
        [NameInMap("hasPermission")]
        [Validation(Required=false)]
        public bool? HasPermission { get; set; }

        /// <summary>
        /// 节点信息
        /// </summary>
        [NameInMap("nodeBO")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeBO { get; set; }

        /// <summary>
        /// 节点所属团队空间信息
        /// </summary>
        [NameInMap("workspaceBO")]
        [Validation(Required=false)]
        public Dictionary<string, object> WorkspaceBO { get; set; }

    }

}
