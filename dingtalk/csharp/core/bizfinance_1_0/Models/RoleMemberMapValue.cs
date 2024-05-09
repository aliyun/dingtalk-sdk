/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class RoleMemberMapValue : TeaModel {
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        [NameInMap("memberList")]
        [Validation(Required=false)]
        public List<RoleMemberMapValueMemberList> MemberList { get; set; }
        public class RoleMemberMapValueMemberList : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

        }

        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

    }

}
