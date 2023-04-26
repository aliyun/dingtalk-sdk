// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizationPriorityListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOrganizationPriorityListResponseBodyResult> Result { get; set; }
        public class GetOrganizationPriorityListResponseBodyResult : TeaModel {
            [NameInMap("color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("priorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }

        }

    }

}
