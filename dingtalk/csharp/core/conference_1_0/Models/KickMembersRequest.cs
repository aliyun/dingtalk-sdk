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
        /// This parameter is required.
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<KickMembersRequestUserList> UserList { get; set; }
        public class KickMembersRequestUserList : TeaModel {
            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
