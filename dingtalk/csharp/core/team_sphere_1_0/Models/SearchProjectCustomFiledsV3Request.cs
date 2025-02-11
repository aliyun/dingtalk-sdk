// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class SearchProjectCustomFiledsV3Request : TeaModel {
        [NameInMap("cfIds")]
        [Validation(Required=false)]
        public string CfIds { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("sfcId")]
        [Validation(Required=false)]
        public string SfcId { get; set; }

    }

}
