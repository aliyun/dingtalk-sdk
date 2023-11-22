// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetNavigationCatalogRequest : TeaModel {
        [NameInMap("bizTraceId")]
        [Validation(Required=false)]
        public string BizTraceId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
