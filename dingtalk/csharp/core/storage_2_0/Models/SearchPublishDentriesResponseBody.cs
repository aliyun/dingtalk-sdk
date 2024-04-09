// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchPublishDentriesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchPublishDentriesResponseBodyItems> Items { get; set; }
        public class SearchPublishDentriesResponseBodyItems : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
