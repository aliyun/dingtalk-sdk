// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListDeptUsersResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListDeptUsersResponseBodyList> List { get; set; }
        public class ListDeptUsersResponseBodyList : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("deptIdList")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}
