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
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_id</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<GetOrgResponseBodyOrgPartitions> Partitions { get; set; }
            public class GetOrgResponseBodyOrgPartitions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC_OSS_PARTITION</para>
                /// </summary>
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetOrgResponseBodyOrgPartitionsQuota Quota { get; set; }
                public class GetOrgResponseBodyOrgPartitionsQuota : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("reserved")]
                    [Validation(Required=false)]
                    public long? Reserved { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SHARE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

            }

        }

    }

}
