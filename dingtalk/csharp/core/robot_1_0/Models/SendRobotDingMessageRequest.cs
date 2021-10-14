// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class SendRobotDingMessageRequest : TeaModel {
        /// <summary>
        /// 模版对应的参数
        /// </summary>
        [NameInMap("contentParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ContentParams { get; set; }

        /// <summary>
        /// 颁发的模版id，可通过宜搭申请：https://yida.alibaba-inc.com/alibaba/web/APP_NSUGAGIQUMI4ESRA7O7D/inst/homepage/#/FORM-WO866371VGXSECXX4M0NC9KSGAT92VSA3TZSK9B
        /// </summary>
        [NameInMap("dingTemplateId")]
        [Validation(Required=false)]
        public string DingTemplateId { get; set; }

        /// <summary>
        /// 群聊的对外开放Id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 接受人的userId列表
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        /// <summary>
        /// 机器人的Id
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
