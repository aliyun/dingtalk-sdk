// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateWorkspaceDocRequest : TeaModel {
        /// <summary>
        /// 文档类型
        /// </summary>
        [NameInMap("docType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// 文档名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 父节点nodeId
        /// </summary>
        [NameInMap("parentNodeId")]
        [Validation(Required=false)]
        public string ParentNodeId { get; set; }

    }

}
