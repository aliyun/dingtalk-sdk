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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小蜜机器人能做什么</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234</para>
        /// </summary>
        [NameInMap("robotAppKey")]
        [Validation(Required=false)]
        public string RobotAppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("sessionUuid")]
        [Validation(Required=false)]
        public string SessionUuid { get; set; }

    }

}
