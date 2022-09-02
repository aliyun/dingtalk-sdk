// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchResponseBody : TeaModel {
        /// <summary>
        /// 节点搜索结果。
        /// </summary>
        [NameInMap("dentryResult")]
        [Validation(Required=false)]
        public SearchResponseBodyDentryResult DentryResult { get; set; }
        public class SearchResponseBodyDentryResult : TeaModel {
            /// <summary>
            /// 是否还有更多数据。
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 搜索命中的节点列表。
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<SearchResponseBodyDentryResultItems> Items { get; set; }
            public class SearchResponseBodyDentryResultItems : TeaModel {
                /// <summary>
                /// 如果内容命中了关键词，会返回该部分内容，带高亮。
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// 创建信息。
                /// </summary>
                [NameInMap("creation")]
                [Validation(Required=false)]
                public OpenActionModel Creation { get; set; }

                /// <summary>
                /// 节点id。
                /// </summary>
                [NameInMap("dentryId")]
                [Validation(Required=false)]
                public string DentryId { get; set; }

                /// <summary>
                /// 节点唯一标识。
                /// </summary>
                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                /// <summary>
                /// 文件名扩展。
                /// </summary>
                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// 节点图标url。
                /// </summary>
                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                /// <summary>
                /// 最后修改信息。
                /// </summary>
                [NameInMap("lastEdition")]
                [Validation(Required=false)]
                public OpenActionModel LastEdition { get; set; }

                /// <summary>
                /// 节点名称，如果命中了关键词，会带有高亮。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 节点原始名称，不带高亮。
                /// </summary>
                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                /// <summary>
                /// 节点的路径。
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// 文件类型。1-文档；2-表格；3-脑图；4-演示；5-白板；6-office文字；7-office表格；8-office ppt；10-多维表格；11-文本；12-图片；13-视频；14-音频；15-压缩文件；16-其他。
                /// </summary>
                [NameInMap("searchFileType")]
                [Validation(Required=false)]
                public int? SearchFileType { get; set; }

                /// <summary>
                /// 节点所属的知识库id。
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                /// <summary>
                /// 文档缩略图url。
                /// </summary>
                [NameInMap("thumbnailUrl")]
                [Validation(Required=false)]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// 节点访问url。
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 分页游标。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// 知识库搜索结果。
        /// </summary>
        [NameInMap("spaceResult")]
        [Validation(Required=false)]
        public SearchResponseBodySpaceResult SpaceResult { get; set; }
        public class SearchResponseBodySpaceResult : TeaModel {
            /// <summary>
            /// 是否还有更多数据。
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 搜索命中的知识库列表。
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<SearchResponseBodySpaceResultItems> Items { get; set; }
            public class SearchResponseBodySpaceResultItems : TeaModel {
                /// <summary>
                /// 知识库图标。
                /// </summary>
                [NameInMap("iconVO")]
                [Validation(Required=false)]
                public SearchResponseBodySpaceResultItemsIconVO IconVO { get; set; }
                public class SearchResponseBodySpaceResultItemsIconVO : TeaModel {
                    /// <summary>
                    /// 图标信息。
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// 知识库图标的类型。
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// 知识库名称，如果命中了关键词，会带有高亮。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 知识库原始名称，不带高亮。
                /// </summary>
                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                /// <summary>
                /// 知识库id。
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                /// <summary>
                /// 知识库访问url。
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// 用户最后一次操作信息。
                /// </summary>
                [NameInMap("userLastOperation")]
                [Validation(Required=false)]
                public SearchResponseBodySpaceResultItemsUserLastOperation UserLastOperation { get; set; }
                public class SearchResponseBodySpaceResultItemsUserLastOperation : TeaModel {
                    /// <summary>
                    /// 操作人名称。
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 操作的时间戳（ms）。
                    /// </summary>
                    [NameInMap("time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

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

}
