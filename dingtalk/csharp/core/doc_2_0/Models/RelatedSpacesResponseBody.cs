// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RelatedSpacesResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<RelatedSpacesResponseBodyItems> Items { get; set; }
        public class RelatedSpacesResponseBodyItems : TeaModel {
            /// <summary>
            /// 封面
            /// </summary>
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// 空间描述信息
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 知识库高清图标
            /// </summary>
            [NameInMap("hdIconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsHdIconVO HdIconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsHdIconVO : TeaModel {
                /// <summary>
                /// 图标
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// 图标类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 知识库图标
            /// </summary>
            [NameInMap("iconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsIconVO IconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsIconVO : TeaModel {
                /// <summary>
                /// 图标
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// 图标类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 知识库id。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 知识库名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 知识库所有者。
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsOwner Owner { get; set; }
            public class RelatedSpacesResponseBodyItemsOwner : TeaModel {
                /// <summary>
                /// 用户名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 用户unionId。
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            /// <summary>
            /// 知识库中最近编辑的三篇文档。
            /// </summary>
            [NameInMap("recentList")]
            [Validation(Required=false)]
            public List<DentryModel> RecentList { get; set; }

            /// <summary>
            /// 知识库类型。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// 知识库访问url。
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// 访问者对当前知识库的权限等信息。
            /// </summary>
            [NameInMap("visitorInfo")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsVisitorInfo VisitorInfo { get; set; }
            public class RelatedSpacesResponseBodyItemsVisitorInfo : TeaModel {
                /// <summary>
                /// 节点的操作列表。
                /// </summary>
                [NameInMap("dentryActions")]
                [Validation(Required=false)]
                public List<string> DentryActions { get; set; }

                /// <summary>
                /// 是否置顶
                /// </summary>
                [NameInMap("pinned")]
                [Validation(Required=false)]
                public bool? Pinned { get; set; }

                /// <summary>
                /// 权限
                /// </summary>
                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// 空间的操作列表。
                /// </summary>
                [NameInMap("spaceActions")]
                [Validation(Required=false)]
                public List<string> SpaceActions { get; set; }

            }

        }

        /// <summary>
        /// 分页游标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
