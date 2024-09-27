// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateVideoConferenceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX的视频会议</para>
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("inviteCaller")]
        [Validation(Required=false)]
        public bool? InviteCaller { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("inviteUserIds")]
        [Validation(Required=false)]
        public List<string> InviteUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27SaQ3iiHLN0uwqcPisedfreNwiEiE</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
