// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetWordCloudResponseBody : TeaModel {
        [NameInMap("words")]
        [Validation(Required=false)]
        public List<GetWordCloudResponseBodyWords> Words { get; set; }
        public class GetWordCloudResponseBodyWords : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
