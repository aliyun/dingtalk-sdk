// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// 分页游标, nextToken不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 权限列表分页数据
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 文件id
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// 有效时间
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 权限成员
            /// </summary>
            [NameInMap("member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsMember Member { get; set; }
            public class ListPermissionsResponseBodyPermissionsMember : TeaModel {
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
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 操作人id
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// 权限角色
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsRole Role { get; set; }
            public class ListPermissionsResponseBodyPermissionsRole : TeaModel {
                /// <summary>
                /// 角色id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 角色名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 空间id
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

    }

}
