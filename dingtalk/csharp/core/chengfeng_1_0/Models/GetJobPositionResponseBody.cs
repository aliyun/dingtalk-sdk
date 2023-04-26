// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetJobPositionResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetJobPositionResponseBodyContent Content { get; set; }
        public class GetJobPositionResponseBodyContent : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("establishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }

            [NameInMap("jobCode")]
            [Validation(Required=false)]
            public string JobCode { get; set; }

            [NameInMap("jobRequirements")]
            [Validation(Required=false)]
            public string JobRequirements { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
