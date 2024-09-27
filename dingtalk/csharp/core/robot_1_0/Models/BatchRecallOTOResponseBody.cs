// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallOTOResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>b5fe11095f46315d8d30d3f8XXXXXX:system error</para>
        /// </summary>
        [NameInMap("failedResult")]
        [Validation(Required=false)]
        public Dictionary<string, string> FailedResult { get; set; }

        [NameInMap("successResult")]
        [Validation(Required=false)]
        public List<string> SuccessResult { get; set; }

    }

}
