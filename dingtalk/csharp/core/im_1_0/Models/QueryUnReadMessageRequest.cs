// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUnReadMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

    }

}
