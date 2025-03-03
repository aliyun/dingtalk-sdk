// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeleteSchoolReportResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteSchoolReportResponseBodyResult Result { get; set; }
        public class DeleteSchoolReportResponseBodyResult : TeaModel {
            [NameInMap("schoolReportId")]
            [Validation(Required=false)]
            public long? SchoolReportId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
