// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class CreateAppGoodsServiceConversationResponseBody : TeaModel {
        /// <summary>
        /// 群名称
        /// </summary>
        [NameInMap("conversationName")]
        [Validation(Required=false)]
        public string ConversationName { get; set; }

        /// <summary>
        /// 是否是新群
        /// </summary>
        [NameInMap("newConversation")]
        [Validation(Required=false)]
        public bool? NewConversation { get; set; }

    }

}
