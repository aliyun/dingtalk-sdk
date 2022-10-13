// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class SendRobotMessageRequest : TeaModel {
        /// <summary>
        /// @人的appuid列表
        /// </summary>
        [NameInMap("atAppUids")]
        [Validation(Required=false)]
        public List<string> AtAppUids { get; set; }

        /// <summary>
        /// @人的手机号列表
        /// </summary>
        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        /// <summary>
        /// @人的unionid列表
        /// </summary>
        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        /// <summary>
        /// @人的userid列表
        /// </summary>
        [NameInMap("atUsers")]
        [Validation(Required=false)]
        public List<string> AtUsers { get; set; }

        /// <summary>
        /// 租户channel
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// 是否@所有人。  true：是  false：否
        /// </summary>
        [NameInMap("isAtAll")]
        [Validation(Required=false)]
        public bool? IsAtAll { get; set; }

        /// <summary>
        /// 消息模板内容替换参数，多媒体类型
        /// </summary>
        [NameInMap("msgMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgMediaIdParamMap { get; set; }

        /// <summary>
        /// 消息模板内容替换参数，普通文本类型
        /// </summary>
        [NameInMap("msgParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> MsgParamMap { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        [NameInMap("msgTemplateId")]
        [Validation(Required=false)]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 消息接收人appuid列表
        /// </summary>
        [NameInMap("receiverAppUids")]
        [Validation(Required=false)]
        public List<string> ReceiverAppUids { get; set; }

        /// <summary>
        /// 消息接收人手机号列表
        /// </summary>
        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        /// <summary>
        /// 消息接收人unionId列表
        /// </summary>
        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        /// <summary>
        /// 消息接收人userId列表
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        /// <summary>
        /// 用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

    }

}
