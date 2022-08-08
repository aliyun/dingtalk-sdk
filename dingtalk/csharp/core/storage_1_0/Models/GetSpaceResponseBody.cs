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
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }
        };

    }

}
