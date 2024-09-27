// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListStarsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("starList")]
        [Validation(Required=false)]
        public List<ListStarsResponseBodyStarList> StarList { get; set; }
        public class ListStarsResponseBodyStarList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dentryInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListDentryInfo DentryInfo { get; set; }
            public class ListStarsResponseBodyStarListDentryInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-01T10:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoCreator Creator { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoCreator : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>union_id</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

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
                /// <para>mobile_url</para>
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-01T10:00:00Z</para>
                /// </summary>
                [NameInMap("modifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("modifier")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoModifier Modifier { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoModifier : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>union_id</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dentry_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pc_url</para>
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

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
                /// <para>FILE</para>
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NO_PERMISSION</para>
            /// </summary>
            [NameInMap("dentryPermissionRole")]
            [Validation(Required=false)]
            public string DentryPermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>star_id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListSpaceInfo SpaceInfo { get; set; }
            public class ListStarsResponseBodyStarListSpaceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>space_id</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>space_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NO_PERMISSION</para>
            /// </summary>
            [NameInMap("spacePermissionRole")]
            [Validation(Required=false)]
            public string SpacePermissionRole { get; set; }

            [NameInMap("starType")]
            [Validation(Required=false)]
            public string StarType { get; set; }

            [NameInMap("teamInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListTeamInfo TeamInfo { get; set; }
            public class ListStarsResponseBodyStarListTeamInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>team_id</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>team_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
