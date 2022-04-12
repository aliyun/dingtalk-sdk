// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryUserRequest : TeaModel {
        /// <summary>
        /// OKR 系统中的用户 ID 列表
        /// </summary>
        [NameInMap("okrUserIds")]
        [Validation(Required=false)]
        public List<string> OkrUserIds { get; set; }

        /// <summary>
        /// 开放平台中用户 ID 列表
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
