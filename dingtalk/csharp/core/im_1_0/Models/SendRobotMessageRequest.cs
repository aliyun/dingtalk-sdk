// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("atAppUserId")]
        [Validation(Required=false)]
        public string AtAppUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("atDingUserId")]
        [Validation(Required=false)]
        public string AtDingUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;content&quot;: &quot;我就是我, 是不一样的烟火&quot;}</para>
        /// </summary>
        [NameInMap("msgContent")]
        [Validation(Required=false)]
        public string MsgContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kelian-custom-service-robot-101</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
