// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListRecentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nextToken</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>recentDentryList</para>
        /// </summary>
        [NameInMap("recentDentryList")]
        [Validation(Required=false)]
        public List<ListRecentsResponseBodyRecentDentryList> RecentDentryList { get; set; }
        public class ListRecentsResponseBodyRecentDentryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("accessTime")]
            [Validation(Required=false)]
            public long? AccessTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("operateType")]
            [Validation(Required=false)]
            public int? OperateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>resource</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public ListRecentsResponseBodyRecentDentryListResource Resource { get; set; }
            public class ListRecentsResponseBodyRecentDentryListResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dentryUuid</para>
                /// </summary>
                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>driveDentryId</para>
                /// </summary>
                [NameInMap("driveDentryId")]
                [Validation(Required=false)]
                public string DriveDentryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>driveSpaceId</para>
                /// </summary>
                [NameInMap("driveSpaceId")]
                [Validation(Required=false)]
                public string DriveSpaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>docx</para>
                /// </summary>
                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spaceInfo</para>
                /// </summary>
                [NameInMap("spaceInfo")]
                [Validation(Required=false)]
                public ListRecentsResponseBodyRecentDentryListResourceSpaceInfo SpaceInfo { get; set; }
                public class ListRecentsResponseBodyRecentDentryListResourceSpaceInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>im</para>
                    /// </summary>
                    [NameInMap("sceneType")]
                    [Validation(Required=false)]
                    public string SceneType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
