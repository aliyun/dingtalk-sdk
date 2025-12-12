// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_app_1_0.Models
{
    public class QueryInstalledCoolAppsInConversationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryInstalledCoolAppsInConversationResponseBodyResult Result { get; set; }
        public class QueryInstalledCoolAppsInConversationResponseBodyResult : TeaModel {
            [NameInMap("coolApps")]
            [Validation(Required=false)]
            public List<QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps> CoolApps { get; set; }
            public class QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps : TeaModel {
                [NameInMap("coolAppCode")]
                [Validation(Required=false)]
                public string CoolAppCode { get; set; }

                [NameInMap("coolAppName")]
                [Validation(Required=false)]
                public string CoolAppName { get; set; }

            }

        }

    }

}
