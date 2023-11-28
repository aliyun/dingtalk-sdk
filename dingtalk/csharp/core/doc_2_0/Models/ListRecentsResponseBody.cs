// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListRecentsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("recentDentryList")]
        [Validation(Required=false)]
        public List<ListRecentsResponseBodyRecentDentryList> RecentDentryList { get; set; }
        public class ListRecentsResponseBodyRecentDentryList : TeaModel {
            [NameInMap("accessTime")]
            [Validation(Required=false)]
            public long? AccessTime { get; set; }

            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("operateType")]
            [Validation(Required=false)]
            public int? OperateType { get; set; }

            [NameInMap("resource")]
            [Validation(Required=false)]
            public ListRecentsResponseBodyRecentDentryListResource Resource { get; set; }
            public class ListRecentsResponseBodyRecentDentryListResource : TeaModel {
                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("driveDentryId")]
                [Validation(Required=false)]
                public string DriveDentryId { get; set; }

                [NameInMap("driveSpaceId")]
                [Validation(Required=false)]
                public string DriveSpaceId { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("spaceInfo")]
                [Validation(Required=false)]
                public ListRecentsResponseBodyRecentDentryListResourceSpaceInfo SpaceInfo { get; set; }
                public class ListRecentsResponseBodyRecentDentryListResourceSpaceInfo : TeaModel {
                    [NameInMap("sceneType")]
                    [Validation(Required=false)]
                    public string SceneType { get; set; }

                }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
