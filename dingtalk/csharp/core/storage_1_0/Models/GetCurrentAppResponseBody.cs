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
            /// <summary>
            /// <b>Example:</b>
            /// <para>app_id</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_id</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<GetCurrentAppResponseBodyAppPartitions> Partitions { get; set; }
            public class GetCurrentAppResponseBodyAppPartitions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC_OSS_PARTITION</para>
                /// </summary>
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetCurrentAppResponseBodyAppPartitionsQuota Quota { get; set; }
                public class GetCurrentAppResponseBodyAppPartitionsQuota : TeaModel {
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
