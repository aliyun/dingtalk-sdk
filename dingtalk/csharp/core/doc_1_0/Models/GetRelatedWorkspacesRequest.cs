// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRelatedWorkspacesRequest : TeaModel {
        /// <summary>
        /// 是否查询最近访问文档列表
        /// </summary>
        [NameInMap("includeRecent")]
        [Validation(Required=false)]
        public bool? IncludeRecent { get; set; }

        /// <summary>
        /// 发起操作用户unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
