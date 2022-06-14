// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class SendMsgRequest : TeaModel {
        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 设备业务标识
        /// </summary>
        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 设备唯一系统标识
        /// </summary>
        [NameInMap("deviceUuid")]
        [Validation(Required=false)]
        public string DeviceUuid { get; set; }

        /// <summary>
        /// 开放群唯一标识
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 用户列表，群聊时为被@的人，单聊时为目标对象
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
