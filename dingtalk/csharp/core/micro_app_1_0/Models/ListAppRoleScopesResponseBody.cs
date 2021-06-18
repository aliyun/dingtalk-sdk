// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListAppRoleScopesResponseBody : TeaModel {
        /// <summary>
        /// 是否还有数据，true: 还有；false: 已经全部拉取完成
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次请求的起始点
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<ListAppRoleScopesResponseBodyDataList> DataList { get; set; }
        public class ListAppRoleScopesResponseBodyDataList : TeaModel {
            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// 角色Id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// 部门id列表
            /// </summary>
            [NameInMap("deptIdList")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            /// <summary>
            /// 员工userId列表
            /// </summary>
            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

            /// <summary>
            /// 角色范围最新版本号
            /// </summary>
            [NameInMap("scopeVersion")]
            [Validation(Required=false)]
            public long? ScopeVersion { get; set; }

            /// <summary>
            /// 是否拥有角色管理权限，默认false
            /// </summary>
            [NameInMap("canManageRole")]
            [Validation(Required=false)]
            public bool? CanManageRole { get; set; }

        }

    }

}
