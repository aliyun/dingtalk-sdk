// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class FindTargetRelatedFollowRecordsRequest : TeaModel {
        [NameInMap("followTargetDataId")]
        [Validation(Required=false)]
        public string FollowTargetDataId { get; set; }

        [NameInMap("followTargetType")]
        [Validation(Required=false)]
        public string FollowTargetType { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
