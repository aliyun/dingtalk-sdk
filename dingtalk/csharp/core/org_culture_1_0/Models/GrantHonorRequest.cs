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
        /// This parameter is required.
        /// </summary>
        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        [NameInMap("noticeAnnouncer")]
        [Validation(Required=false)]
        public bool? NoticeAnnouncer { get; set; }

        [NameInMap("noticeSingle")]
        [Validation(Required=false)]
        public bool? NoticeSingle { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
