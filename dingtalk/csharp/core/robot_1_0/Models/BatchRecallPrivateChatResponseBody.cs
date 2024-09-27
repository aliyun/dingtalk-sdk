// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallPrivateChatResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("failedResult")]
        [Validation(Required=false)]
        public Dictionary<string, string> FailedResult { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<string> SuccessResult { get; set; }

    }

}
