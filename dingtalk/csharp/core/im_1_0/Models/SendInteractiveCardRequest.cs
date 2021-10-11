// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendInteractiveCardRequest : TeaModel {
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        /// <summary>
        /// 卡片模板ID
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 接收卡片的群的openConversationId
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        /// <summary>
        /// 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        /// <summary>
        /// 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// 卡片公共主体部分数据
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public SendInteractiveCardRequestCardData CardData { get; set; }
        public class SendInteractiveCardRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }
            [NameInMap("cardMediaIdParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardMediaIdParamMap { get; set; }
        };

        /// <summary>
        /// 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        /// </summary>
        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        /// <summary>
        /// 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        /// </summary>
        [NameInMap("chatBotId")]
        [Validation(Required=false)]
        public string ChatBotId { get; set; }

        /// <summary>
        /// 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        /// </summary>
        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

        /// <summary>
        /// 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
        /// </summary>
        [NameInMap("atOpenIds")]
        [Validation(Required=false)]
        public Dictionary<string, string> AtOpenIds { get; set; }

    }

}
