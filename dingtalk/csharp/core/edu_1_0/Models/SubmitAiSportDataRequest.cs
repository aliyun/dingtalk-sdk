// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SubmitAiSportDataRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, string> Data { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
