// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchDentriesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchDentriesResponseBodyItems> Items { get; set; }
        public class SearchDentriesResponseBodyItems : TeaModel {
            [NameInMap("creator")]
            [Validation(Required=false)]
            public SearchDentriesResponseBodyItemsCreator Creator { get; set; }
            public class SearchDentriesResponseBodyItemsCreator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public SearchDentriesResponseBodyItemsModifier Modifier { get; set; }
            public class SearchDentriesResponseBodyItemsModifier : TeaModel {
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

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
