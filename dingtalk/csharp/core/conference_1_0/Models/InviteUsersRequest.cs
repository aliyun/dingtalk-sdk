// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class InviteUsersRequest : TeaModel {
        [NameInMap("inviteeList")]
        [Validation(Required=false)]
        public List<InviteUsersRequestInviteeList> InviteeList { get; set; }
        public class InviteUsersRequestInviteeList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("phoneInviteeList")]
        [Validation(Required=false)]
        public List<InviteUsersRequestPhoneInviteeList> PhoneInviteeList { get; set; }
        public class InviteUsersRequestPhoneInviteeList : TeaModel {
            [NameInMap("inviteClient")]
            [Validation(Required=false)]
            public bool? InviteClient { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("phoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("statusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
