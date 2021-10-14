// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartStreamOutResponseBody : TeaModel {
        /// <summary>
        /// 失败的地址与失败原因映射
        /// </summary>
        [NameInMap("failStreamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailStreamMap { get; set; }

        /// <summary>
        /// 成功推流地址与liveId映射
        /// </summary>
        [NameInMap("successStreamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SuccessStreamMap { get; set; }

    }

}
