// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchResponseBody : TeaModel {
        [NameInMap("dentryResult")]
        [Validation(Required=false)]
        public SearchResponseBodyDentryResult DentryResult { get; set; }
        public class SearchResponseBodyDentryResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<SearchResponseBodyDentryResultItems> Items { get; set; }
            public class SearchResponseBodyDentryResultItems : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("creation")]
                [Validation(Required=false)]
                public OpenActionModel Creation { get; set; }

                [NameInMap("dentryId")]
                [Validation(Required=false)]
                public string DentryId { get; set; }

                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                [NameInMap("lastEdition")]
                [Validation(Required=false)]
                public OpenActionModel LastEdition { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("sceneType")]
                [Validation(Required=false)]
                public int? SceneType { get; set; }

                [NameInMap("searchFileType")]
                [Validation(Required=false)]
                public int? SearchFileType { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("thumbnailUrl")]
                [Validation(Required=false)]
                public string ThumbnailUrl { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("spaceResult")]
        [Validation(Required=false)]
        public SearchResponseBodySpaceResult SpaceResult { get; set; }
        public class SearchResponseBodySpaceResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<SearchResponseBodySpaceResultItems> Items { get; set; }
            public class SearchResponseBodySpaceResultItems : TeaModel {
                [NameInMap("iconVO")]
                [Validation(Required=false)]
                public SearchResponseBodySpaceResultItemsIconVO IconVO { get; set; }
                public class SearchResponseBodySpaceResultItemsIconVO : TeaModel {
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("originName")]
                [Validation(Required=false)]
                public string OriginName { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("teamVO")]
                [Validation(Required=false)]
                public SearchResponseBodySpaceResultItemsTeamVO TeamVO { get; set; }
                public class SearchResponseBodySpaceResultItemsTeamVO : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("userLastOperation")]
                [Validation(Required=false)]
                public SearchResponseBodySpaceResultItemsUserLastOperation UserLastOperation { get; set; }
                public class SearchResponseBodySpaceResultItemsUserLastOperation : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
