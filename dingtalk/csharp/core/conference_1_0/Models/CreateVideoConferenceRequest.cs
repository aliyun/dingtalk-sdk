// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateVideoConferenceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        [NameInMap("inviteCaller")]
        [Validation(Required=false)]
        public bool? InviteCaller { get; set; }

        [NameInMap("inviteUserIds")]
        [Validation(Required=false)]
        public List<string> InviteUserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
