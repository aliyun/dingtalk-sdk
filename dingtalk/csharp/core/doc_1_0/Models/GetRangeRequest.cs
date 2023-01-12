// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRangeRequest : TeaModel {
        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 限定要返回的字段
        /// </summary>
        [NameInMap("select")]
        [Validation(Required=false)]
        public string Select { get; set; }

    }

}
