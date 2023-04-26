// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetOrgResponseBody : TeaModel {
        [NameInMap("org")]
        [Validation(Required=false)]
        public GetOrgResponseBodyOrg Org { get; set; }
        public class GetOrgResponseBodyOrg : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<GetOrgResponseBodyOrgPartitions> Partitions { get; set; }
            public class GetOrgResponseBodyOrgPartitions : TeaModel {
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetOrgResponseBodyOrgPartitionsQuota Quota { get; set; }
                public class GetOrgResponseBodyOrgPartitionsQuota : TeaModel {
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
