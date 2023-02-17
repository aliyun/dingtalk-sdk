// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// OKR系统内部用户id
        /// </summary>
        [NameInMap("okrUserId")]
        [Validation(Required=false)]
        public string OkrUserId { get; set; }

        /// <summary>
        /// 钉钉UserId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
