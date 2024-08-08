// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabDataRequest : TeaModel {
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("relatedField")]
        [Validation(Required=false)]
        public string RelatedField { get; set; }

        [NameInMap("relatedInstId")]
        [Validation(Required=false)]
        public string RelatedInstId { get; set; }

        [NameInMap("viewUserId")]
        [Validation(Required=false)]
        public string ViewUserId { get; set; }

    }

}
