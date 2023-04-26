// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetNegativeWordCloudResponseBody : TeaModel {
        [NameInMap("words")]
        [Validation(Required=false)]
        public List<GetNegativeWordCloudResponseBodyWords> Words { get; set; }
        public class GetNegativeWordCloudResponseBodyWords : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
