// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPartnerRolesResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListPartnerRolesResponseBodyList> List { get; set; }
        public class ListPartnerRolesResponseBodyList : TeaModel {
            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 是否必邀角色
            /// </summary>
            [NameInMap("isNecessary")]
            [Validation(Required=false)]
            public int? IsNecessary { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 可见部门
            /// </summary>
            [NameInMap("visibleDepts")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListVisibleDepts> VisibleDepts { get; set; }
            public class ListPartnerRolesResponseBodyListVisibleDepts : TeaModel {
                /// <summary>
                /// 部门id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 可见员工
            /// </summary>
            [NameInMap("visibleUsers")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListVisibleUsers> VisibleUsers { get; set; }
            public class ListPartnerRolesResponseBodyListVisibleUsers : TeaModel {
                /// <summary>
                /// 员工姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 员工id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 预警部门
            /// </summary>
            [NameInMap("warningDepts")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListWarningDepts> WarningDepts { get; set; }
            public class ListPartnerRolesResponseBodyListWarningDepts : TeaModel {
                /// <summary>
                /// 部门id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 预警成员
            /// </summary>
            [NameInMap("warningUsers")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListWarningUsers> WarningUsers { get; set; }
            public class ListPartnerRolesResponseBodyListWarningUsers : TeaModel {
                /// <summary>
                /// 员工姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 员工id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
