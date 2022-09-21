// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ApplyFollowerAuthInfoRequest : TeaModel {
        /// <summary>
        /// 申请的授权数据，多个数据时使用,分隔
        /// </summary>
        [NameInMap("fieldScope")]
        [Validation(Required=false)]
        public string FieldScope { get; set; }

        /// <summary>
        /// 客服会话sessionId
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
