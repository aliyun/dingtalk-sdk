// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class BatchSendRequest : TeaModel {
        /// <summary>
        /// 接受者列表，外部用户
        /// </summary>
        [NameInMap("appUids")]
        [Validation(Required=false)]
        public List<string> AppUids { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 发送者，企业员工账号
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
