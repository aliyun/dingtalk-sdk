// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddSceneGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxxxx==</para>
        /// </summary>
        [NameInMap("open_conversation_id")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("union_ids")]
        [Validation(Required=false)]
        public List<string> UnionIds { get; set; }

        [NameInMap("user_ids")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
