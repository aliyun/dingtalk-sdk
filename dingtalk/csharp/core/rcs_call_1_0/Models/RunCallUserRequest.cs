// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrcs_call_1_0.Models
{
    public class RunCallUserRequest : TeaModel {
        [NameInMap("authorizeCorpId")]
        [Validation(Required=false)]
        public string AuthorizeCorpId { get; set; }

        [NameInMap("authorizeUserId")]
        [Validation(Required=false)]
        public string AuthorizeUserId { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
