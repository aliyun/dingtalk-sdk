// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddSpaceResponseBody : TeaModel {
        /// <summary>
        /// 空间详情
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public AddSpaceResponseBodySpace Space { get; set; }
        public class AddSpaceResponseBodySpace : TeaModel {
            /// <summary>
            /// 开放平台应用appId
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// 空间能力项
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public AddSpaceResponseBodySpaceCapabilities Capabilities { get; set; }
            public class AddSpaceResponseBodySpaceCapabilities : TeaModel {
                /// <summary>
                /// 是否进最近使用, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                /// <summary>
                /// 是否支持重命名空间名称, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

                /// <summary>
                /// 是否支持搜索, 默认不支持
                /// 默认值:
                /// 	false
                /// </summary>
                [NameInMap("canSearch")]
                [Validation(Required=false)]
                public bool? CanSearch { get; set; }

            }

            /// <summary>
            /// 空间归属企业的id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

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
            /// 空间id
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
            /// 空间名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 所有者id, 根据ownerType定义, 确定值的所属类型
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// owner类型
            /// 枚举值:
            /// 	USER: 用户类型
            /// 	APP: App类型
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// 分区容量信息
            /// 最大size:
            /// 	2
            /// </summary>
            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<AddSpaceResponseBodySpacePartitions> Partitions { get; set; }
            public class AddSpaceResponseBodySpacePartitions : TeaModel {
                /// <summary>
                /// 分区类型
                /// 枚举值:
                /// 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
                /// 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
                /// </summary>
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                /// <summary>
                /// 容量信息
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public AddSpaceResponseBodySpacePartitionsQuota Quota { get; set; }
                public class AddSpaceResponseBodySpacePartitionsQuota : TeaModel {
                    /// <summary>
                    /// 最大容量, 单位: Byte
                    /// 当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max
                    /// 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
                    /// </summary>
                    [NameInMap("max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    /// <summary>
                    /// 预分配剩余容量, 单位: Byte
                    /// 背景：
                    ///    管理后台可以给应用或空间预分配容量，此字段表示预分剩余容量，即预分配容量中未使用部分
                    /// 如果没有设置预分配容，此字段是空
                    /// </summary>
                    [NameInMap("reserved")]
                    [Validation(Required=false)]
                    public long? Reserved { get; set; }

                    /// <summary>
                    /// 容量类型
                    /// 如果是企业维度容量，此值是PRIVATE, 表示企业独占
                    /// 枚举值:
                    /// 	SHARE: 共享容量
                    /// 此模式下，Quota.max为空，表示共享企业容量
                    /// 	PRIVATE: 预分配容量（专享容量）
                    /// 当Quota.max设置值后，表示容量独占
                    /// 使用场景：需要保证单个应用的可用容量不受其他应用影响时, 可使用预分配容量（专享容量）
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// 实际已使用容量, 单位: Byte
                    /// 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更
                    /// 最小值:
                    /// 	0
                    /// </summary>
                    [NameInMap("used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

            }

            /// <summary>
            /// 容量上限
            /// 管理后台设置的容量上限
            /// 建议使用分区上容量信息字段
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。
            /// 创建空间时，不指定scene, 默认值是default
            /// 默认值:
            /// 	default
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
            /// 默认值:
            /// 	0
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// 空间状态
            /// 枚举值:
            /// 	NORMAL: 正常
            /// 	DELETE: 已删除
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 已使用容量, 包含各分区已使用容量和
            /// 建议使用分区上容量信息字段
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
