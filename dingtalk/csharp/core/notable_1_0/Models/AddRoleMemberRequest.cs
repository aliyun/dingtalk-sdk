// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class AddRoleMemberRequest : TeaModel {
        [NameInMap("roleMemberList")]
        [Validation(Required=false)]
        public List<AddRoleMemberRequestRoleMemberList> RoleMemberList { get; set; }
        public class AddRoleMemberRequestRoleMemberList : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("memberIdBelongOrgId")]
            [Validation(Required=false)]
            public long? MemberIdBelongOrgId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("roleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
