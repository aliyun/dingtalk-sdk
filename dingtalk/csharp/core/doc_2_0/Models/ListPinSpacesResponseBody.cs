// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListPinSpacesResponseBody : TeaModel {
        /// <summary>
        /// 分页游标
        /// 不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 知识库置顶数据集合
        /// 最大size:
        /// 	20
        /// </summary>
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<ListPinSpacesResponseBodyResultItems> ResultItems { get; set; }
        public class ListPinSpacesResponseBodyResultItems : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            public ListPinSpacesResponseBodyResultItemsSpaceInfo SpaceInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsSpaceInfo : TeaModel {
                /// <summary>
                /// 知识库封面路径
                /// </summary>
                [NameInMap("cover")]
                [Validation(Required=false)]
                public string Cover { get; set; }

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
                public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator Creator { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator : TeaModel {
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
                /// 知识库描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 知识库图标
                /// </summary>
                [NameInMap("iconVO")]
                [Validation(Required=false)]
                public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO IconVO { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO : TeaModel {
                    /// <summary>
                    /// 图片存放地址
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// 图片存放类型
                    /// 枚举值:
                    /// 	UNICODE: unicode
                    /// 	URL: url
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// 知识库id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Mobile 访问链接
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
                public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier Modifier { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier : TeaModel {
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
                /// 知识库名称
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
            /// 小组信息
            /// </summary>
            [NameInMap("teamInfo")]
            [Validation(Required=false)]
            public ListPinSpacesResponseBodyResultItemsTeamInfo TeamInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsTeamInfo : TeaModel {
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
