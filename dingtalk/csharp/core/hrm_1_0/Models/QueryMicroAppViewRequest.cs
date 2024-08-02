// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryMicroAppViewRequest : TeaModel {
        [NameInMap("tenantIdList")]
        [Validation(Required=false)]
        public List<long?> TenantIdList { get; set; }

        [NameInMap("viewUserId")]
        [Validation(Required=false)]
        public string ViewUserId { get; set; }

    }

}
