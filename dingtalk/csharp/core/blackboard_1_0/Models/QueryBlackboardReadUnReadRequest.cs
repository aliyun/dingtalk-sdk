// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models
{
    public class QueryBlackboardReadUnReadRequest : TeaModel {
        [NameInMap("blackboardId")]
        [Validation(Required=false)]
        public string BlackboardId { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("operationUserId")]
        [Validation(Required=false)]
        public string OperationUserId { get; set; }

    }

}
