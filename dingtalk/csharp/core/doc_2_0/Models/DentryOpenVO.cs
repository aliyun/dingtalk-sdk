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
    public class DentryOpenVO : TeaModel {
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
        public DentryOpenVOCreator Creator { get; set; }
        public class DentryOpenVOCreator : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
        };

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
        public SpaceOpenVO Space { get; set; }

        /// <summary>
        /// 知识库id。
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

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
        public DentryOpenVOUpdater Updater { get; set; }
        public class DentryOpenVOUpdater : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
        };

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
        public DentryOpenVOVisitorInfo VisitorInfo { get; set; }
        public class DentryOpenVOVisitorInfo : TeaModel {
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }
            [NameInMap("spaceActions")]
            [Validation(Required=false)]
            public List<string> SpaceActions { get; set; }
        };

    }

}
