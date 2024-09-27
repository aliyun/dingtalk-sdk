// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListPinSpacesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<ListPinSpacesResponseBodyResultItems> ResultItems { get; set; }
        public class ListPinSpacesResponseBodyResultItems : TeaModel {
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

            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public ListPinSpacesResponseBodyResultItemsSpaceInfo SpaceInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsSpaceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>space_cover</para>
                /// </summary>
                [NameInMap("cover")]
                [Validation(Required=false)]
                public string Cover { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-01T10:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator Creator { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator : TeaModel {
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
                /// <para>description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("iconVO")]
                [Validation(Required=false)]
                public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO IconVO { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>icon_url</para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>URL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>space_id</para>
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
                public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier Modifier { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier : TeaModel {
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
                /// <para>space_name</para>
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NO_PERMISSION</para>
            /// </summary>
            [NameInMap("spacePermissionRole")]
            [Validation(Required=false)]
            public string SpacePermissionRole { get; set; }

            [NameInMap("teamInfo")]
            [Validation(Required=false)]
            public ListPinSpacesResponseBodyResultItemsTeamInfo TeamInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsTeamInfo : TeaModel {
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
