// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyGetMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyGetMemberResponseBodyResult Result { get; set; }
        public class SupplyGetMemberResponseBodyResult : TeaModel {
            [NameInMap("deptIdList")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李白</para>
            /// </summary>
            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>经理</para>
            /// </summary>
            [NameInMap("memberTitle")]
            [Validation(Required=false)]
            public string MemberTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

            [NameInMap("roleInfoList")]
            [Validation(Required=false)]
            public List<SupplyGetMemberResponseBodyResultRoleInfoList> RoleInfoList { get; set; }
            public class SupplyGetMemberResponseBodyResultRoleInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("roleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>老板</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            [NameInMap("supplyNodeList")]
            [Validation(Required=false)]
            public List<long?> SupplyNodeList { get; set; }

        }

    }

}
