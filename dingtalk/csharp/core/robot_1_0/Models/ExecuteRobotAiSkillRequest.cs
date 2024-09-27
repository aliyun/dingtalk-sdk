// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class ExecuteRobotAiSkillRequest : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Dictionary<string, object> Context { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("skillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

    }

}
