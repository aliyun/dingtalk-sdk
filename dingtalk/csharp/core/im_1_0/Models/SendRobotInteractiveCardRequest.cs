// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendRobotInteractiveCardRequest : TeaModel {
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("pullStrategy")]
        [Validation(Required=false)]
        public bool? PullStrategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("sendOptions")]
        [Validation(Required=false)]
        public SendRobotInteractiveCardRequestSendOptions SendOptions { get; set; }
        public class SendRobotInteractiveCardRequestSendOptions : TeaModel {
            [NameInMap("atAll")]
            [Validation(Required=false)]
            public bool? AtAll { get; set; }

            [NameInMap("atUserListJson")]
            [Validation(Required=false)]
            public string AtUserListJson { get; set; }

            [NameInMap("cardPropertyJson")]
            [Validation(Required=false)]
            public string CardPropertyJson { get; set; }

            [NameInMap("receiverListJson")]
            [Validation(Required=false)]
            public string ReceiverListJson { get; set; }

        }

        [NameInMap("singleChatReceiver")]
        [Validation(Required=false)]
        public string SingleChatReceiver { get; set; }

        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UnionIdPrivateDataMap { get; set; }

        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UserIdPrivateDataMap { get; set; }

    }

}
