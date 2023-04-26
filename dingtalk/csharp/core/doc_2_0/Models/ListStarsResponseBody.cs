// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListStarsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("starList")]
        [Validation(Required=false)]
        public List<ListStarsResponseBodyStarList> StarList { get; set; }
        public class ListStarsResponseBodyStarList : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dentryInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListDentryInfo DentryInfo { get; set; }
            public class ListStarsResponseBodyStarListDentryInfo : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoCreator Creator { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoCreator : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                [NameInMap("modifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("modifier")]
                [Validation(Required=false)]
                public ListStarsResponseBodyStarListDentryInfoModifier Modifier { get; set; }
                public class ListStarsResponseBodyStarListDentryInfoModifier : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("dentryPermissionRole")]
            [Validation(Required=false)]
            public string DentryPermissionRole { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListSpaceInfo SpaceInfo { get; set; }
            public class ListStarsResponseBodyStarListSpaceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
