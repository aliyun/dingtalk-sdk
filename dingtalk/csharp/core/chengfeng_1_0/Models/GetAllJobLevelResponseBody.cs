// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetAllJobLevelResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CfJobLevelResp> Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请求ID</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
