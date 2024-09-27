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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户</para>
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qzR1iSMDvzR9kXXXXXXXx</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("phoneInviteeList")]
        [Validation(Required=false)]
        public List<InviteUsersRequestPhoneInviteeList> PhoneInviteeList { get; set; }
        public class InviteUsersRequestPhoneInviteeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("inviteClient")]
            [Validation(Required=false)]
            public bool? InviteClient { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试电话用户</para>
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1xxxxxxxxxx9</para>
            /// </summary>
            [NameInMap("phoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("statusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qzR1iSMDvzR9iPXXXXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
