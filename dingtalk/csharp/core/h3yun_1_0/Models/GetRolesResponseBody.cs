// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRolesResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRolesResponseBodyData Data { get; set; }
        public class GetRolesResponseBodyData : TeaModel {
            [NameInMap("roleGroups")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoleGroups> RoleGroups { get; set; }
            public class GetRolesResponseBodyDataRoleGroups : TeaModel {
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string GroupCode { get; set; }
                public string CompanyId { get; set; }
                public string Visibility { get; set; }
                public string State { get; set; }
                public string Description { get; set; }
            }
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoles> Roles { get; set; }
            public class GetRolesResponseBodyDataRoles : TeaModel {
                public string RoleId { get; set; }
                public string RoleName { get; set; }
                public string RoleCode { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string State { get; set; }
                public string Visibility { get; set; }
                public string CompanyId { get; set; }
            }
        };

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
