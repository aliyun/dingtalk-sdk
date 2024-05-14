// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class RelatedSpacesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<RelatedSpacesResponseBodyItems> Items { get; set; }
        public class RelatedSpacesResponseBodyItems : TeaModel {
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("hdIconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsHdIconVO HdIconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsHdIconVO : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("iconVO")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsIconVO IconVO { get; set; }
            public class RelatedSpacesResponseBodyItemsIconVO : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsOwner Owner { get; set; }
            public class RelatedSpacesResponseBodyItemsOwner : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("recentList")]
            [Validation(Required=false)]
            public List<DentryModel> RecentList { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("visitorInfo")]
            [Validation(Required=false)]
            public RelatedSpacesResponseBodyItemsVisitorInfo VisitorInfo { get; set; }
            public class RelatedSpacesResponseBodyItemsVisitorInfo : TeaModel {
                [NameInMap("dentryActions")]
                [Validation(Required=false)]
                public List<string> DentryActions { get; set; }

                [NameInMap("pinned")]
                [Validation(Required=false)]
                public bool? Pinned { get; set; }

                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                [NameInMap("spaceActions")]
                [Validation(Required=false)]
                public List<string> SpaceActions { get; set; }

            }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
