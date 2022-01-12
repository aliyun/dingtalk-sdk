// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateVideoConferenceRequest : TeaModel {
        /// <summary>
        /// 会议主题： 文字，不超过20中文
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        /// <summary>
        /// 是否邀请主叫
        /// </summary>
        [NameInMap("inviteCaller")]
        [Validation(Required=false)]
        public bool? InviteCaller { get; set; }

        /// <summary>
        /// 邀请参会人员UID列表（必须好友或同事）
        /// </summary>
        [NameInMap("inviteUserIds")]
        [Validation(Required=false)]
        public List<string> InviteUserIds { get; set; }

        /// <summary>
        /// 会议发起人UID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
