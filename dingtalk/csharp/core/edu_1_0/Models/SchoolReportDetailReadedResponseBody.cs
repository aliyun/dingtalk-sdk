// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SchoolReportDetailReadedResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SchoolReportDetailReadedResponseBodyResult Result { get; set; }
        public class SchoolReportDetailReadedResponseBodyResult : TeaModel {
            [NameInMap("schoolReportDetailId")]
            [Validation(Required=false)]
            public List<string> SchoolReportDetailId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
