// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchRecallGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("chatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidfCSpXXXXXXXXXXXchatbotId</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("processQueryKeys")]
        [Validation(Required=false)]
        public List<string> ProcessQueryKeys { get; set; }

    }

}
