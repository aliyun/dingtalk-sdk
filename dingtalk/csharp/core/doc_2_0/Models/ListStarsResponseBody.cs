// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListStarsResponseBody : TeaModel {
        /// <summary>
        /// 分页游标
        /// 不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 星标数据集合
        /// 最大size:
        /// 	20
        /// </summary>
        [NameInMap("starList")]
        [Validation(Required=false)]
        public List<ListStarsResponseBodyStarList> StarList { get; set; }
        public class ListStarsResponseBodyStarList : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 资源实体数据
            /// </summary>
            [NameInMap("dentryInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListDentryInfo DentryInfo { get; set; }
            public class ListStarsResponseBodyStarListDentryInfo : TeaModel {
                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 创建者信息
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoCreator Creator { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoCreator : TeaModel {
                    /// <summary>
                    /// 用户名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 用户id
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 后缀
                /// </summary>
                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Mobile访问链接
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("modifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// 修改者信息
                /// </summary>
                [NameInMap("modifier")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoModifier Modifier { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoModifier : TeaModel {
                    /// <summary>
                    /// 用户名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 用户id
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// PC 访问链接
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                /// <summary>
                /// 所在空间id
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                /// <summary>
                /// 状态
                /// 枚举值:
                /// 	NORMAL: 正常
                /// 	DELETED: 已删除
                /// 	EXPIRED: 已过期
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 类型，目录或文件
                /// 枚举值:
                /// 	FILE: 文件
                /// 	FOLDER: 文件夹
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// uuid，如移动文件，此字段不变
                /// </summary>
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// 文档权限
            /// 枚举值:
            /// 	NO_PERMISSION: 无权限
            /// 	READ_ONLY: 仅可查看
            /// 	READ_AND_DOWNLOAD: 可查看/下载
            /// 	EDIT: 可编辑
            /// 	MANAGER: 可管理
            /// 	OWNER: 所有者
            /// </summary>
            [NameInMap("dentryPermissionRole")]
            [Validation(Required=false)]
            public string DentryPermissionRole { get; set; }

            /// <summary>
            /// 星标id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 是否已经删除
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 知识库信息
            /// </summary>
            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListSpaceInfo SpaceInfo { get; set; }
            public class ListStarsResponseBodyStarListSpaceInfo : TeaModel {
                /// <summary>
                /// 空间id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 空间名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 知识库权限
            /// 枚举值:
            /// 	NO_PERMISSION: 无权限
            /// 	READ_ONLY: 仅可查看
            /// 	READ_AND_DOWNLOAD: 可查看/下载
            /// 	EDIT: 可编辑
            /// 	MANAGER: 可管理
            /// 	OWNER: 所有者
            /// </summary>
            [NameInMap("spacePermissionRole")]
            [Validation(Required=false)]
            public string SpacePermissionRole { get; set; }

            /// <summary>
            /// 星标类型
            /// 枚举值:
            /// 	TOP: 置顶星标
            /// 	COMMON: 普通星标
            /// </summary>
            [NameInMap("starType")]
            [Validation(Required=false)]
            public string StarType { get; set; }

            /// <summary>
            /// 小组信息
            /// </summary>
            [NameInMap("teamInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListTeamInfo TeamInfo { get; set; }
            public class ListStarsResponseBodyStarListTeamInfo : TeaModel {
                /// <summary>
                /// 小组id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 小组名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
