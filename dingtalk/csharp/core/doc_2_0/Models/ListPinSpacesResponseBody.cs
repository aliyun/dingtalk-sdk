// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListPinSpacesResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<ListPinSpacesResponseBodyResultItems> ResultItems { get; set; }
        public class ListPinSpacesResponseBodyResultItems : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public ListPinSpacesResponseBodyResultItemsSpaceInfo SpaceInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsSpaceInfo : TeaModel {
                [NameInMap("cover")]
                [Validation(Required=false)]
                public string Cover { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public ListPinSpacesResponseBodyResultItemsSpaceInfoCreator Creator { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("iconVO")]
                [Validation(Required=false)]
                public ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO IconVO { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO : TeaModel {
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

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
                public ListPinSpacesResponseBodyResultItemsSpaceInfoModifier Modifier { get; set; }
                public class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier : TeaModel {
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

            }

            [NameInMap("spacePermissionRole")]
            [Validation(Required=false)]
            public string SpacePermissionRole { get; set; }

            [NameInMap("teamInfo")]
            [Validation(Required=false)]
            public ListPinSpacesResponseBodyResultItemsTeamInfo TeamInfo { get; set; }
            public class ListPinSpacesResponseBodyResultItemsTeamInfo : TeaModel {
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
