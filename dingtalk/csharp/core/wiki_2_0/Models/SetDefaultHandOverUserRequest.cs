// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class SetDefaultHandOverUserRequest : TeaModel {
        [NameInMap("defaultHandoverUserId")]
        [Validation(Required=false)]
        public string DefaultHandoverUserId { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
