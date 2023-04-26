// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetSignedDetailByPageResponseBody : TeaModel {
        [NameInMap("auditSignedDetailDTOList")]
        [Validation(Required=false)]
        public List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> AuditSignedDetailDTOList { get; set; }
        public class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("roles")]
            [Validation(Required=false)]
            public string Roles { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
