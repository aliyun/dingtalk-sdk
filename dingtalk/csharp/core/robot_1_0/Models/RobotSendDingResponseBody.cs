// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class RobotSendDingResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailedList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("openDingId")]
        [Validation(Required=false)]
        public string OpenDingId { get; set; }

    }

}
