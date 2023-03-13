/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class DentryModel : TeaModel {
        /// <summary>
        /// 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// 创建者。
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public DentryModelCreator Creator { get; set; }
        public class DentryModelCreator : TeaModel {
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
        /// 节点id。
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// 节点类型。file-文件；folder-文件夹。
        /// </summary>
        [NameInMap("dentryType")]
        [Validation(Required=false)]
        public string DentryType { get; set; }

        /// <summary>
        /// 节点全局唯一标识id。
        /// </summary>
        [NameInMap("dentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// 文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。
        /// </summary>
        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        /// <summary>
        /// 文件后缀名。
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// 是否有子节点。
        /// </summary>
        [NameInMap("hasChildren")]
        [Validation(Required=false)]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// 快捷方式类型的节点，其指向的原始数据信息。
        /// </summary>
        [NameInMap("linkSourceInfo")]
        [Validation(Required=false)]
        public LinkSourceInfo LinkSourceInfo { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 节点的路径。
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// 知识库信息。
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public SpaceModel Space { get; set; }

        /// <summary>
        /// 知识库id。
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// 统计信息
        /// </summary>
        [NameInMap("statisticalInfo")]
        [Validation(Required=false)]
        public DentryModelStatisticalInfo StatisticalInfo { get; set; }
        public class DentryModelStatisticalInfo : TeaModel {
            /// <summary>
            /// 字数
            /// </summary>
            [NameInMap("wordCount")]
            [Validation(Required=false)]
            public long? WordCount { get; set; }

        }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// 更新人。
        /// </summary>
        [NameInMap("updater")]
        [Validation(Required=false)]
        public DentryModelUpdater Updater { get; set; }
        public class DentryModelUpdater : TeaModel {
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
        /// 节点访问url。
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 访问者对当前节点的权限等信息。
        /// </summary>
        [NameInMap("visitorInfo")]
        [Validation(Required=false)]
        public DentryModelVisitorInfo VisitorInfo { get; set; }
        public class DentryModelVisitorInfo : TeaModel {
            /// <summary>
            /// 节点的操作列表。
            /// </summary>
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }

            /// <summary>
            /// 当前用户对这个空间的访问角色。
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

}
