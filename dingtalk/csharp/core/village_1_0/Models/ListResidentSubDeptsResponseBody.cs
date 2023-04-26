// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentSubDeptsResponseBody : TeaModel {
        [NameInMap("departmentList")]
        [Validation(Required=false)]
        public List<ListResidentSubDeptsResponseBodyDepartmentList> DepartmentList { get; set; }
        public class ListResidentSubDeptsResponseBodyDepartmentList : TeaModel {
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("superDepartmentId")]
            [Validation(Required=false)]
            public long? SuperDepartmentId { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
