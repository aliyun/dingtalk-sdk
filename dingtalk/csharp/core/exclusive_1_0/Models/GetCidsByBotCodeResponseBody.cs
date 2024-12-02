// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCidsByBotCodeResponseBody : TeaModel {
        [NameInMap("groupInfos")]
        [Validation(Required=false)]
        public List<GetCidsByBotCodeResponseBodyGroupInfos> GroupInfos { get; set; }
        public class GetCidsByBotCodeResponseBodyGroupInfos : TeaModel {
            [NameInMap("botCreator")]
            [Validation(Required=false)]
            public string BotCreator { get; set; }

            [NameInMap("botCreatorIsOrgMember")]
            [Validation(Required=false)]
            public bool? BotCreatorIsOrgMember { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}
