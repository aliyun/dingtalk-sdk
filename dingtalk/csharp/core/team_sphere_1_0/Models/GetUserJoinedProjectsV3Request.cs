// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetUserJoinedProjectsV3Request : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

        [NameInMap("projectRoleLevels")]
        [Validation(Required=false)]
        public string ProjectRoleLevels { get; set; }

        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
