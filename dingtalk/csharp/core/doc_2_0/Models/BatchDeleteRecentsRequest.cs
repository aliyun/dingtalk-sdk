// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class BatchDeleteRecentsRequest : TeaModel {
        /// <summary>
        /// 移除最近记录文档uuid
        /// 最大size:
        /// 	20
        /// </summary>
        [NameInMap("dentryUuids")]
        [Validation(Required=false)]
        public List<string> DentryUuids { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
