// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class KickMembersRequest : TeaModel {
        [NameInMap("forbiddenRejoin")]
        [Validation(Required=false)]
        public bool? ForbiddenRejoin { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<KickMembersRequestUserList> UserList { get; set; }
        public class KickMembersRequestUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>644272f14ba3311xxxxxxxxx</para>
            /// </summary>
            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
