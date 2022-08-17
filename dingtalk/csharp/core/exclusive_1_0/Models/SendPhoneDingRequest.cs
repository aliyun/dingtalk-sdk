// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SendPhoneDingRequest : TeaModel {
        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 接收DING消息的用户列表
        /// </summary>
        [NameInMap("userids")]
        [Validation(Required=false)]
        public List<string> Userids { get; set; }

    }

}
