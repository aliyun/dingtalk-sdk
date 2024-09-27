// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class PushRobotMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("chatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

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
        /// <para>eyJjb250ZW50IjogIua1i+ivleWGheWuuSJ9(即{&quot;content&quot;: &quot;测试内容&quot;}的base64编码值)</para>
        /// </summary>
        [NameInMap("msgParam")]
        [Validation(Required=false)]
        public string MsgParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456abc</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
