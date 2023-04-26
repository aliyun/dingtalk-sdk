// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddRelationDatasResponseBody : TeaModel {
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchAddRelationDatasResponseBodyResults> Results { get; set; }
        public class BatchAddRelationDatasResponseBodyResults : TeaModel {
            [NameInMap("duplicatedRelationIds")]
            [Validation(Required=false)]
            public List<string> DuplicatedRelationIds { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
