// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppAvailableVersionResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppAvailableVersionResponseBodyList> List { get; set; }
        public class ListMiniAppAvailableVersionResponseBodyList : TeaModel {
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
