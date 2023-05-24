// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddPartnerManagersRequest : TeaModel {
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("interfaceId")]
        [Validation(Required=false)]
        public string InterfaceId { get; set; }

        [NameInMap("interfaceType")]
        [Validation(Required=false)]
        public string InterfaceType { get; set; }

    }

}
