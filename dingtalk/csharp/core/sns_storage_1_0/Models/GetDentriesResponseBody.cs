// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models
{
    public class GetDentriesResponseBody : TeaModel {
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<GetDentriesResponseBodyResultItems> ResultItems { get; set; }
        public class GetDentriesResponseBodyResultItems : TeaModel {
            [NameInMap("dentry")]
            [Validation(Required=false)]
            public GetDentriesResponseBodyResultItemsDentry Dentry { get; set; }
            public class GetDentriesResponseBodyResultItemsDentry : TeaModel {
                [NameInMap("appProperties")]
                [Validation(Required=false)]
                public Dictionary<string, List<ResultItemsDentryAppPropertiesValue>> AppProperties { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

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

                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("properties")]
                [Validation(Required=false)]
                public GetDentriesResponseBodyResultItemsDentryProperties Properties { get; set; }
                public class GetDentriesResponseBodyResultItemsDentryProperties : TeaModel {
                    [NameInMap("readOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("storageDriver")]
                [Validation(Required=false)]
                public string StorageDriver { get; set; }

                [NameInMap("thumbnail")]
                [Validation(Required=false)]
                public GetDentriesResponseBodyResultItemsDentryThumbnail Thumbnail { get; set; }
                public class GetDentriesResponseBodyResultItemsDentryThumbnail : TeaModel {
                    [NameInMap("height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
