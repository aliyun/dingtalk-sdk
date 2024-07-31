// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryRecordMinutesUrlResponseBody : TeaModel {
        [NameInMap("recordMinutesUrls")]
        [Validation(Required=false)]
        public List<QueryRecordMinutesUrlResponseBodyRecordMinutesUrls> RecordMinutesUrls { get; set; }
        public class QueryRecordMinutesUrlResponseBodyRecordMinutesUrls : TeaModel {
            [NameInMap("recordMinutesUrl")]
            [Validation(Required=false)]
            public string RecordMinutesUrl { get; set; }

        }

    }

}
