// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class AskRobotRequest : TeaModel {
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("robotAppKey")]
        [Validation(Required=false)]
        public string RobotAppKey { get; set; }

        [NameInMap("sessionUuid")]
        [Validation(Required=false)]
        public string SessionUuid { get; set; }

    }

}
