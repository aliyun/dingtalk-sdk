// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetCurrentAppResponseBody : TeaModel {
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
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetCurrentAppResponseBodyAppPartitionsQuota Quota { get; set; }
                public class GetCurrentAppResponseBodyAppPartitionsQuota : TeaModel {
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

        }

    }

}
