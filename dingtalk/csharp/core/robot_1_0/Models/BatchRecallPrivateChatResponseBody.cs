// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallPrivateChatResponseBody : TeaModel {
        /// <summary>
        /// 撤回失败的消息id及原因
        /// </summary>
        [NameInMap("failedResult")]
        [Validation(Required=false)]
        public Dictionary<string, string> FailedResult { get; set; }

        /// <summary>
        /// 撤回成功的消息id
        /// </summary>
        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<string> SuccessResult { get; set; }

    }

}
