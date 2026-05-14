// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateSceneGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatxxxxxx</para>
        /// </summary>
        [NameInMap("chat_id")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxxxx==</para>
        /// </summary>
        [NameInMap("open_conversation_id")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
