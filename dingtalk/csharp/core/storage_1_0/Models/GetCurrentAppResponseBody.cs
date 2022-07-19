// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetCurrentAppResponseBody : TeaModel {
        /// <summary>
        /// 企业存储应用信息
        /// </summary>
        [NameInMap("app")]
        [Validation(Required=false)]
        public GetCurrentAppResponseBodyApp App { get; set; }
        public class GetCurrentAppResponseBodyApp : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<GetCurrentAppResponseBodyAppPartitions> Partitions { get; set; }
            public class GetCurrentAppResponseBodyAppPartitions : TeaModel {
                public string PartitionType { get; set; }
                public GetCurrentAppResponseBodyAppPartitionsQuota Quota { get; set; }
                public class GetCurrentAppResponseBodyAppPartitionsQuota : TeaModel {
                    /// <summary>
                    /// 最大容量, 单位: Byte
                    /// 当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max
                    /// 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
                    /// </summary>
                    [NameInMap("max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    /// <summary>
                    /// 容量类型
                    /// 枚举值:
                    /// 	SHARE: 共享容量
                    /// 此模式下，Quota.max为空，表示共享企业容量
                    /// 	PRIVATE: 专享容量
                    /// 当Quota.max设置值后，表示容量独占
                    /// 使用场景：当需要保证单个应用的可用容量不受其他应用影响时, 可使用共享容量
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// 已使用容量, 单位: Byte
                    /// 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更
                    /// </summary>
                    [NameInMap("used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }
            }
        };

    }

}
