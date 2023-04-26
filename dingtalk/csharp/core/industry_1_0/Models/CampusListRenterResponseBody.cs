// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListRenterResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListRenterResponseBodyResult> Result { get; set; }
        public class CampusListRenterResponseBodyResult : TeaModel {
            [NameInMap("bindRenterCorpId")]
            [Validation(Required=false)]
            public string BindRenterCorpId { get; set; }

            [NameInMap("bindTime")]
            [Validation(Required=false)]
            public long? BindTime { get; set; }

            [NameInMap("creditCode")]
            [Validation(Required=false)]
            public string CreditCode { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("renterDeptId")]
            [Validation(Required=false)]
            public long? RenterDeptId { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

        }

    }

}
