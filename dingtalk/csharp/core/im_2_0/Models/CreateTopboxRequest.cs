// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateTopboxRequest : TeaModel {
        /// <summary>
        /// 可控制卡片回调时的路由Key，用于指定特定的callbackUrl。
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// 卡片数据。
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateTopboxRequestCardData CardData { get; set; }
        public class CreateTopboxRequestCardData : TeaModel {
            /// <summary>
            /// 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
            /// </summary>
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// 卡片设置项。
        /// </summary>
        [NameInMap("cardSettings")]
        [Validation(Required=false)]
        public CreateTopboxRequestCardSettings CardSettings { get; set; }
        public class CreateTopboxRequestCardSettings : TeaModel {
            /// <summary>
            /// 是否开启卡片纯拉模式。
            /// </summary>
            [NameInMap("pullStrategy")]
            [Validation(Required=false)]
            public bool? PullStrategy { get; set; }

        }

        /// <summary>
        /// 互动卡片的消息模板ID
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 会话类型。
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        /// <summary>
        /// 酷应用编码。
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// 吊顶的过期时间，绝对时间。
        /// </summary>
        [NameInMap("expiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// 群模板id。
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// 会话id。
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 唯一标识一张卡片的外部ID。
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 期望吊顶的端，如果有多个用“｜”分隔。 例如：ios|mac|android|win表示iOS、MAC、安卓和windows端。
        /// </summary>
        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string Platforms { get; set; }

        /// <summary>
        /// 吊顶可见者unionId，最多可传100个unionId。
        /// </summary>
        [NameInMap("receiverUnionIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIdList { get; set; }

        /// <summary>
        /// 吊顶可见者userId，最多可传100个userId。
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        /// <summary>
        /// 单聊助手会话，机器人编码。
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 卡片模板unionId差异用户参数。
        /// </summary>
        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UnionIdPrivateDataMapValue> UnionIdPrivateDataMap { get; set; }

        /// <summary>
        /// 单聊助手会话，用户unionId。
        /// </summary>
        [NameInMap("unoinId")]
        [Validation(Required=false)]
        public string UnoinId { get; set; }

        /// <summary>
        /// 单聊助手会话，用户userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 卡片模板userId差异用户参数。
        /// </summary>
        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public Dictionary<string, UserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

    }

}
