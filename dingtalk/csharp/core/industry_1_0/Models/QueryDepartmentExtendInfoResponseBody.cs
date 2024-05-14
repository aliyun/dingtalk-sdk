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
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptExtendDisplayName")]
            [Validation(Required=false)]
            public string DeptExtendDisplayName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptExtendKey")]
            [Validation(Required=false)]
            public string DeptExtendKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptExtendValue")]
            [Validation(Required=false)]
            public string DeptExtendValue { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
