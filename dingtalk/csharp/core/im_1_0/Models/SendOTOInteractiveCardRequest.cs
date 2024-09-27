// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendOTOInteractiveCardRequest : TeaModel {
        [NameInMap("atOpenIds")]
        [Validation(Required=false)]
        public Dictionary<string, string> AtOpenIds { get; set; }

        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public SendOTOInteractiveCardRequestCardData CardData { get; set; }
        public class SendOTOInteractiveCardRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        [NameInMap("cardOptions")]
        [Validation(Required=false)]
        public SendOTOInteractiveCardRequestCardOptions CardOptions { get; set; }
        public class SendOTOInteractiveCardRequestCardOptions : TeaModel {
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("pullStrategy")]
        [Validation(Required=false)]
        public bool? PullStrategy { get; set; }

        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
