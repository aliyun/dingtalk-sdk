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
                /// <para>txt</para>
                /// </summary>
                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dentry_id</para>
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
                /// <para>dentry_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>parent_id</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC_OSS_PARTITION</para>
                /// </summary>
                [NameInMap("partitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dentry_path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("properties")]
                [Validation(Required=false)]
                public GetDentriesResponseBodyResultItemsDentryProperties Properties { get; set; }
                public class GetDentriesResponseBodyResultItemsDentryProperties : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("readOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>space_id</para>
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DINGTALK</para>
                /// </summary>
                [NameInMap("storageDriver")]
                [Validation(Required=false)]
                public string StorageDriver { get; set; }

                [NameInMap("thumbnail")]
                [Validation(Required=false)]
                public GetDentriesResponseBodyResultItemsDentryThumbnail Thumbnail { get; set; }
                public class GetDentriesResponseBodyResultItemsDentryThumbnail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>url</para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>uuid</para>
                /// </summary>
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>permissionDenied</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
