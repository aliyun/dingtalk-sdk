// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetPropertyInfoResponseBody : TeaModel {
        [NameInMap("adminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        [NameInMap("adminUserId")]
        [Validation(Required=false)]
        public string AdminUserId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}
