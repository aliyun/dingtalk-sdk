// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetConversationIdRequest : TeaModel {
        /// <summary>
        /// 外部用户账号：outerId@channel
        /// </summary>
        [NameInMap("appUid")]
        [Validation(Required=false)]
        public string AppUid { get; set; }

        /// <summary>
        /// 员工企业账号：staffId#corpId@dingding
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
