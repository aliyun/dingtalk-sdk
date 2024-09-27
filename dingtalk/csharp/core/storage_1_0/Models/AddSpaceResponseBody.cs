// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class AddSpaceResponseBody : TeaModel {
        [NameInMap("space")]
        [Validation(Required=false)]
        public AddSpaceResponseBodySpace Space { get; set; }
        public class AddSpaceResponseBodySpace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app_id</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public AddSpaceResponseBodySpaceCapabilities Capabilities { get; set; }
            public class AddSpaceResponseBodySpaceCapabilities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canRecordRecentFile")]
                [Validation(Required=false)]
                public bool? CanRecordRecentFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canRename")]
                [Validation(Required=false)]
                public bool? CanRename { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canSearch")]
                [Validation(Required=false)]
                public bool? CanSearch { get; set; }

            }

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
            /// <para>creator_id</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>modifier_id</para>
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>owner_id</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("partitions")]
            [Validation(Required=false)]
            public List<AddSpaceResponseBodySpacePartitions> Partitions { get; set; }
            public class AddSpaceResponseBodySpacePartitions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC_OSS_PARTITION</para>
                /// </summary>
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public AddSpaceResponseBodySpacePartitionsQuota Quota { get; set; }
                public class AddSpaceResponseBodySpacePartitionsQuota : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scene</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scene_id</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
