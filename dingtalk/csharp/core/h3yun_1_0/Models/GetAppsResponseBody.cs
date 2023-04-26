// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAppsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAppsResponseBodyData> Data { get; set; }
        public class GetAppsResponseBodyData : TeaModel {
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("appSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            [NameInMap("appState")]
            [Validation(Required=false)]
            public string AppState { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
