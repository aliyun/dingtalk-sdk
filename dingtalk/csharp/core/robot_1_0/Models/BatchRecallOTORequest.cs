// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallOTORequest : TeaModel {
        /// <summary>
        /// 消息id
        /// </summary>
        [NameInMap("processQueryKeys")]
        [Validation(Required=false)]
        public List<string> ProcessQueryKeys { get; set; }

        /// <summary>
        /// 机器人的robotCode
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
