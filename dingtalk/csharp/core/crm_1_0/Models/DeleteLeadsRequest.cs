// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DeleteLeadsRequest : TeaModel {
        /// <summary>
        /// 线索ID列表。
        /// </summary>
        [NameInMap("outLeadsIds")]
        [Validation(Required=false)]
        public List<string> OutLeadsIds { get; set; }

    }

}
