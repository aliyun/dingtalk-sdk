// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetChildOrgListResponseBody : TeaModel {
        /// <summary>
        /// 返回内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CfOrgResp> Content { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
