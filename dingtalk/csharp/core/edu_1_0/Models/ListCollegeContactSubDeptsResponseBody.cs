// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListCollegeContactSubDeptsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCollegeContactSubDeptsResponseBodyResult> Result { get; set; }
        public class ListCollegeContactSubDeptsResponseBodyResult : TeaModel {
            [NameInMap("autoAddUser")]
            [Validation(Required=false)]
            public bool? AutoAddUser { get; set; }

            [NameInMap("createDeptGroup")]
            [Validation(Required=false)]
            public bool? CreateDeptGroup { get; set; }

            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("fromUnionOrg")]
            [Validation(Required=false)]
            public bool? FromUnionOrg { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("sourceIdentifier")]
            [Validation(Required=false)]
            public string SourceIdentifier { get; set; }

            [NameInMap("struId")]
            [Validation(Required=false)]
            public long? StruId { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
