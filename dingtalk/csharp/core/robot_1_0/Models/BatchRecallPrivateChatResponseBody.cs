// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallPrivateChatResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("failedResult")]
        [Validation(Required=false)]
        public Dictionary<string, string> FailedResult { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<string> SuccessResult { get; set; }

    }

}
