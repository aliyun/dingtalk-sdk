// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetProjectRolesV3Request : TeaModel {
        [NameInMap("includeHidden")]
        [Validation(Required=false)]
        public bool? IncludeHidden { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
