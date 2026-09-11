// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryServiceRecordLocationShrinkRequest : TeaModel {
        [NameInMap("locationAmountLimit")]
        [Validation(Required=false)]
        public long? LocationAmountLimit { get; set; }

        [NameInMap("recordIdList")]
        [Validation(Required=false)]
        public string RecordIdListShrink { get; set; }

    }

}
