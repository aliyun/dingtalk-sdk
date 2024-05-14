// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateTopboxRequest : TeaModel {
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateTopboxRequestCardData CardData { get; set; }
        public class CreateTopboxRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        [NameInMap("cardSettings")]
        [Validation(Required=false)]
        public CreateTopboxRequestCardSettings CardSettings { get; set; }
        public class CreateTopboxRequestCardSettings : TeaModel {
            [NameInMap("pullStrategy")]
            [Validation(Required=false)]
            public bool? PullStrategy { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        [NameInMap("expiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string Platforms { get; set; }

        [NameInMap("receiverUnionIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIdList { get; set; }

        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UnionIdPrivateDataMapValue> UnionIdPrivateDataMap { get; set; }

        [NameInMap("unoinId")]
        [Validation(Required=false)]
        public string UnoinId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

    }

}
