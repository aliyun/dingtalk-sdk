// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class CopyDentryResponseBody : TeaModel {
        /// <summary>
        /// 是否是异步任务
        /// 如果操作对象有子节点，则会异步处理
        /// </summary>
        [NameInMap("async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// 文件信息
        /// </summary>
        [NameInMap("dentry")]
        [Validation(Required=false)]
        public CopyDentryResponseBodyDentry Dentry { get; set; }
        public class CopyDentryResponseBodyDentry : TeaModel {
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
            public CopyDentryResponseBodyDentryProperties Properties { get; set; }
            public class CopyDentryResponseBodyDentryProperties : TeaModel {
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

        /// <summary>
        /// 任务id，用于查询任务执行状态; 查询接口开发中
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
