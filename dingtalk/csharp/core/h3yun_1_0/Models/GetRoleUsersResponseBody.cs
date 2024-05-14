// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRoleUsersResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetRoleUsersResponseBodyData> Data { get; set; }
        public class GetRoleUsersResponseBodyData : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("partDepartmentIds")]
            [Validation(Required=false)]
            public List<string> PartDepartmentIds { get; set; }

            [NameInMap("sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
