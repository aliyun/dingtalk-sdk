// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddPermissionRequest : TeaModel {
        /// <summary>
        /// 权限成员列表
        /// 最大size:
        /// 	30
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<AddPermissionRequestMembers> Members { get; set; }
        public class AddPermissionRequestMembers : TeaModel {
            /// <summary>
            /// 权限归属的企业
            /// 如果存在企业id, 对应member离职的时候会自动清理权限
            /// 如果memberType是dept类型，必须要有企业id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 权限成员id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 权限成员类型
            /// 枚举值:
            /// 	ORG: 企业
            /// 	DEPT: 部门
            /// 	TAG: 自定义tag
            /// 	CONVERSATION: 会话
            /// 	GG: 通用组
            /// 	USER: 用户
            /// 	ALL_USERS: 所有用户
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public AddPermissionRequestOption Option { get; set; }
        public class AddPermissionRequestOption : TeaModel {
            /// <summary>
            /// 有效时间(秒)
            /// 最大值:
            /// 	3600
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// 权限角色id
        /// </summary>
        [NameInMap("roleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
