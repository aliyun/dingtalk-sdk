// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchResponseBody : TeaModel {
        /// <summary>
        /// 节点搜索结果。
        /// </summary>
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
                public string Content { get; set; }
                public OpenActionModel Creation { get; set; }
                public string DentryId { get; set; }
                public string DentryUuid { get; set; }
                public string Extension { get; set; }
                public int? FileType { get; set; }
                public string IconUrl { get; set; }
                public OpenActionModel LastEdition { get; set; }
                public string Name { get; set; }
                public string OriginName { get; set; }
                public string Path { get; set; }
                public string SpaceId { get; set; }
                public string Url { get; set; }
            }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        /// <summary>
        /// 知识库搜索结果。
        /// </summary>
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
                public string Name { get; set; }
                public string OriginName { get; set; }
                public string SpaceId { get; set; }
                public string Url { get; set; }
            }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
