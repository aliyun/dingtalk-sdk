// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListDentryVersionsResponseBody : TeaModel {
        /// <summary>
        /// 文件版本列表
        /// </summary>
        [NameInMap("dentries")]
        [Validation(Required=false)]
        public List<ListDentryVersionsResponseBodyDentries> Dentries { get; set; }
        public class ListDentryVersionsResponseBodyDentries : TeaModel {
            /// <summary>
            /// 在特定应用上的属性。key是微应用Id, value是属性列表。
            /// 可以通过修改DentryAppProperty里的scope来设置属性的可见性
            /// </summary>
            [NameInMap("appProperties")]
            [Validation(Required=false)]
            public Dictionary<string, List<DentriesAppPropertiesValue>> AppProperties { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 创建者id
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

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
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 修改者id
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 父目录id, 根目录id值为0
            /// 空值代表根目录的parentId不存在
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
            /// 枚举值:
            /// 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
            /// 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
            /// </summary>
            [NameInMap("partitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            /// <summary>
            /// 路径
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// 属性
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public ListDentryVersionsResponseBodyDentriesProperties Properties { get; set; }
            public class ListDentryVersionsResponseBodyDentriesProperties : TeaModel {
                /// <summary>
                /// 文件是否只读
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// 大小, 单位:Byte
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

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
            /// 驱动类型
            /// 枚举值:
            /// 	DINGTALK: 钉钉统一存储驱动
            /// 	ALIDOC: 钉钉文档存储驱动
            /// 	SHANJI: 闪记存储驱动
            /// 	UNKNOWN: 未知驱动
            /// </summary>
            [NameInMap("storageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

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

            /// <summary>
            /// 版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// 分页游标
        /// 不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
