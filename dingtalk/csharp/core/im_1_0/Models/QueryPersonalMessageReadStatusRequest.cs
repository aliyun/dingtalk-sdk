// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryPersonalMessageReadStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidQGfKJCXMfVxZxxx3ZL0Qlw==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msghnezLi8wb6pGqMsadhj9n0yw==</para>
        /// </summary>
        [NameInMap("openMessageId")]
        [Validation(Required=false)]
        public string OpenMessageId { get; set; }

    }

}
