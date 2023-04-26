// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateMemberBanWordsRequest : TeaModel {
        [NameInMap("muteDuration")]
        [Validation(Required=false)]
        public long? MuteDuration { get; set; }

        [NameInMap("muteStatus")]
        [Validation(Required=false)]
        public int? MuteStatus { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
