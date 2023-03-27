// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetAllJobPositionResponseBody : TeaModel {
        /// <summary>
        /// 职位列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CfJobPositionResp> Content { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
