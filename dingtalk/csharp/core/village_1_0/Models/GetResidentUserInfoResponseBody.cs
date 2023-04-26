// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetResidentUserInfoResponseBody : TeaModel {
        [NameInMap("feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<GetResidentUserInfoResponseBodyRoles> Roles { get; set; }
        public class GetResidentUserInfoResponseBodyRoles : TeaModel {
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
