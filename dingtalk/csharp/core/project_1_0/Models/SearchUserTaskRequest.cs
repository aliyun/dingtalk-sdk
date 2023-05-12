// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public string RoleTypes { get; set; }

        [NameInMap("tql")]
        [Validation(Required=false)]
        public string Tql { get; set; }

    }

}
