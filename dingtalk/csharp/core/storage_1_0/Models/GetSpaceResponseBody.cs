// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetSpaceResponseBody : TeaModel {
        [NameInMap("space")]
        [Validation(Required=false)]
        public GetSpaceResponseBodySpace Space { get; set; }
        public class GetSpaceResponseBodySpace : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public GetSpaceResponseBodySpaceCapabilities Capabilities { get; set; }
            public class GetSpaceResponseBodySpaceCapabilities : TeaModel {
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

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

            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<GetSpaceResponseBodySpacePartitions> Partitions { get; set; }
            public class GetSpaceResponseBodySpacePartitions : TeaModel {
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetSpaceResponseBodySpacePartitionsQuota Quota { get; set; }
                public class GetSpaceResponseBodySpacePartitionsQuota : TeaModel {
                    [NameInMap("max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    [NameInMap("reserved")]
                    [Validation(Required=false)]
                    public long? Reserved { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

            }

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

        }

    }

}
