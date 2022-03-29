// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateFileStatusRequest : TeaModel {
        /// <summary>
        /// 请求id列表
        /// </summary>
        [NameInMap("requestIds")]
        [Validation(Required=false)]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 更新的状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
