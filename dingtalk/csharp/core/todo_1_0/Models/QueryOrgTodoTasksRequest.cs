// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoTasksRequest : TeaModel {
        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public List<List<string>> RoleTypes { get; set; }

    }

}
