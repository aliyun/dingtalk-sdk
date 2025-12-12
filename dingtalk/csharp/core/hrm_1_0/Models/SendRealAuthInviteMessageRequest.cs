// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SendRealAuthInviteMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inviterId")]
        [Validation(Required=false)]
        public string InviterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("onWorkingEmpSearchVO")]
        [Validation(Required=false)]
        public SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO OnWorkingEmpSearchVO { get; set; }
        public class SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
