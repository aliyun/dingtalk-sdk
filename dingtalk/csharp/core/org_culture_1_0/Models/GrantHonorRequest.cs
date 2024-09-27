// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class GrantHonorRequest : TeaModel {
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>表现优秀，特此奖励！</para>
        /// </summary>
        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>组织文化团队</para>
        /// </summary>
        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noticeAnnouncer")]
        [Validation(Required=false)]
        public bool? NoticeAnnouncer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noticeSingle")]
        [Validation(Required=false)]
        public bool? NoticeSingle { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxUserId</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
