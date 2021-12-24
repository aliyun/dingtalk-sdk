// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryHospitalRolesResponseBody : TeaModel {
        /// <summary>
        /// 角色列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryHospitalRolesResponseBodyContent> Content { get; set; }
        public class QueryHospitalRolesResponseBodyContent : TeaModel {
            /// <summary>
            /// 主键
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 是否已删除，默认0未删除，1已删除
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public long? IsDeleted { get; set; }

            /// <summary>
            /// 角色编码
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 排序，数字越小越靠前，默认0
            /// </summary>
            [NameInMap("sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            /// <summary>
            /// 角色关联权限点是否只读
            /// </summary>
            [NameInMap("readOnly")]
            [Validation(Required=false)]
            public long? ReadOnly { get; set; }

        }

    }

}
