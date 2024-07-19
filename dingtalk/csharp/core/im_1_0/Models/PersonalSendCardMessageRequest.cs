// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class PersonalSendCardMessageRequest : TeaModel {
        [NameInMap("atUserIds")]
        [Validation(Required=false)]
        public List<string> AtUserIds { get; set; }

        [NameInMap("cardContent")]
        [Validation(Required=false)]
        public PersonalSendCardMessageRequestCardContent CardContent { get; set; }
        public class PersonalSendCardMessageRequestCardContent : TeaModel {
            [NameInMap("lastMessage")]
            [Validation(Required=false)]
            public string LastMessage { get; set; }

            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

        }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("receiveUserId")]
        [Validation(Required=false)]
        public string ReceiveUserId { get; set; }

    }

}
