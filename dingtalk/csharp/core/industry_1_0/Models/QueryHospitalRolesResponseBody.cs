// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryHospitalRolesResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryHospitalRolesResponseBodyContent> Content { get; set; }
        public class QueryHospitalRolesResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public long? IsDeleted { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("readOnly")]
            [Validation(Required=false)]
            public long? ReadOnly { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

        }

    }

}
