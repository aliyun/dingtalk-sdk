// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionByUserIdResponseBody : TeaModel {
        [NameInMap("permissionDTOList")]
        [Validation(Required=false)]
        public List<QueryPermissionByUserIdResponseBodyPermissionDTOList> PermissionDTOList { get; set; }
        public class QueryPermissionByUserIdResponseBodyPermissionDTOList : TeaModel {
            [NameInMap("actionIdList")]
            [Validation(Required=false)]
            public List<string> ActionIdList { get; set; }

            [NameInMap("resourceIdentity")]
            [Validation(Required=false)]
            public string ResourceIdentity { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
