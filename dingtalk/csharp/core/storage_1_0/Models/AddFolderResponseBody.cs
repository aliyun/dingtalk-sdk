// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddFolderResponseBody : TeaModel {
        /// <summary>
        /// 文件夹信息
        /// dentry.type等于FOLDER表示是文件夹
        /// </summary>
        [NameInMap("dentry")]
        [Validation(Required=false)]
        public AddFolderResponseBodyDentry Dentry { get; set; }
        public class AddFolderResponseBodyDentry : TeaModel {
            [NameInMap("appProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> AppProperties { get; set; }
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
            public AddFolderResponseBodyDentryProperties Properties { get; set; }
            public class AddFolderResponseBodyDentryProperties : TeaModel {
                /// <summary>
                /// 文件是否只读
                /// </summary>
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
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
        };

    }

}
