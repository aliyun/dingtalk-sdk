// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentExtendInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryDepartmentExtendInfoResponseBodyContent> Content { get; set; }
        public class QueryDepartmentExtendInfoResponseBodyContent : TeaModel {
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            [NameInMap("deptExtendDisplayName")]
            [Validation(Required=false)]
            public string DeptExtendDisplayName { get; set; }

            [NameInMap("deptExtendKey")]
            [Validation(Required=false)]
            public string DeptExtendKey { get; set; }

            [NameInMap("deptExtendValue")]
            [Validation(Required=false)]
            public string DeptExtendValue { get; set; }

            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
