// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetColumnvalsRequest : TeaModel {
        [NameInMap("columnIdList")]
        [Validation(Required=false)]
        public List<string> ColumnIdList { get; set; }

        [NameInMap("fromDate")]
        [Validation(Required=false)]
        public long? FromDate { get; set; }

        [NameInMap("toDate")]
        [Validation(Required=false)]
        public long? ToDate { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
