// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class RePushSuiteTicketRequest : TeaModel {
        [NameInMap("suiteId")]
        [Validation(Required=false)]
        public long? SuiteId { get; set; }

        [NameInMap("suiteSecret")]
        [Validation(Required=false)]
        public string SuiteSecret { get; set; }

    }

}
