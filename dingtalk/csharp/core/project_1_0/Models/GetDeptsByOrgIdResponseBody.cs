// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetDeptsByOrgIdResponseBody : TeaModel {
        [NameInMap("deptList")]
        [Validation(Required=false)]
        public List<GetDeptsByOrgIdResponseBodyDeptList> DeptList { get; set; }
        public class GetDeptsByOrgIdResponseBodyDeptList : TeaModel {
            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parent_id")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
