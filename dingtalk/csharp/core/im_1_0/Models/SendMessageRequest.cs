// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;msg_type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello world&quot;}</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("receiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("senderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;9d801647a64<b><b><b>59c9da0207&quot;:&quot;[{&quot;action_url&quot;:&quot;<a href="http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%80%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D,%7B%5C%22action_url%5C%22:%5C%22http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%A4%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D%5D">http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;一个按钮\&quot;},{\&quot;action_url\&quot;:\&quot;http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;两个按钮\&quot;}]</a>&quot;,     &quot;9d801647a6</b></b></b>59c9da020342&quot;:&quot;[{&quot;action_url&quot;:&quot;<a href="http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%80%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D,%7B%5C%22action_url%5C%22:%5C%22http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%A4%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D%5D">http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;一个按钮\&quot;},{\&quot;action_url\&quot;:\&quot;http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;两个按钮\&quot;}]</a>&quot; }</para>
        /// </summary>
        [NameInMap("sourceInfos")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceInfos { get; set; }

    }

}
