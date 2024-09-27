// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class AddGroupMembersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<AddGroupMembersRequestMembers> Members { get; set; }
        public class AddGroupMembersRequestMembers : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

    }

}
