// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class PrivateChatSendRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COOLAPP-1-10182EEDD1AC0BA600D9000J</para>
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sampleText</para>
        /// </summary>
        [NameInMap("msgKey")]
        [Validation(Required=false)]
        public string MsgKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;今天吃肘子&quot;}</para>
        /// </summary>
        [NameInMap("msgParam")]
        [Validation(Required=false)]
        public string MsgParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cid6KeBBLoveMJOGXoYKF5x7EeiodoA==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingue4kfzdxbyn0pjqd</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
