// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetEmployeeInfoByWorkNoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetEmployeeInfoByWorkNoResponseBodyContent Content { get; set; }
        public class GetEmployeeInfoByWorkNoResponseBodyContent : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
