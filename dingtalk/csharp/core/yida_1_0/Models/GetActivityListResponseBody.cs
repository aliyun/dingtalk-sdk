// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetActivityListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetActivityListResponseBodyResult> Result { get; set; }
        public class GetActivityListResponseBodyResult : TeaModel {
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("activityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("activityNameInEnglish")]
            [Validation(Required=false)]
            public string ActivityNameInEnglish { get; set; }

        }

    }

}
