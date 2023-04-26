// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class ListObjectiveByUserResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public ListObjectiveByUserResponseBodyContent Content { get; set; }
        public class ListObjectiveByUserResponseBodyContent : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("objectives")]
            [Validation(Required=false)]
            public List<OpenObjectiveDTO> Objectives { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
