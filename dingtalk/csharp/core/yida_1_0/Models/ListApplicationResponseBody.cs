// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListApplicationResponseBodyData> Data { get; set; }
        public class ListApplicationResponseBodyData : TeaModel {
            [NameInMap("appConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("applicationStatus")]
            [Validation(Required=false)]
            public string ApplicationStatus { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("inexistence")]
            [Validation(Required=false)]
            public string Inexistence { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("subCorpId")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

            [NameInMap("systemToken")]
            [Validation(Required=false)]
            public string SystemToken { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
