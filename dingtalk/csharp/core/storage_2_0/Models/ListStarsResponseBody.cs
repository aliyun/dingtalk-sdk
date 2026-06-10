// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListStarsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

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

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("resource")]
            [Validation(Required=false)]
            public ListStarsResponseBodyStarListResource Resource { get; set; }
            public class ListStarsResponseBodyStarListResource : TeaModel {
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("dentryType")]
                [Validation(Required=false)]
                public string DentryType { get; set; }

                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("starType")]
            [Validation(Required=false)]
            public long? StarType { get; set; }

        }

    }

}
