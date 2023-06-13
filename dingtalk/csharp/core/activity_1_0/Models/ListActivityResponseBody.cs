// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkactivity_1_0.Models
{
    public class ListActivityResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListActivityResponseBodyList> List { get; set; }
        public class ListActivityResponseBodyList : TeaModel {
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("bannerMediaId")]
            [Validation(Required=false)]
            public string BannerMediaId { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
