// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateTopboxRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abcxxx</para>
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56xxx-xxx</para>
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COOLAPP-x-xxx</para>
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1850042969000</para>
        /// </summary>
        [NameInMap("expiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxxxx==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxx</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ios|win</para>
        /// </summary>
        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string Platforms { get; set; }

        [NameInMap("receiverUnionIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIdList { get; set; }

        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jHsR7xxx</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UnionIdPrivateDataMapValue> UnionIdPrivateDataMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>011xxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

    }

}
