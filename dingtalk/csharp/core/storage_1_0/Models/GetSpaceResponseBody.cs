// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetSpaceResponseBody : TeaModel {
        /// <summary>
        /// 空间详情
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public GetSpaceResponseBodySpace Space { get; set; }
        public class GetSpaceResponseBodySpace : TeaModel {
            /// <summary>
            /// 空间能力项
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public GetSpaceResponseBodySpaceCapabilities Capabilities { get; set; }
            public class GetSpaceResponseBodySpaceCapabilities : TeaModel {
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
            /// 总容量
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
            /// 已使用容量
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
