// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SubmitTaskPackageResponseBody : TeaModel {
        [NameInMap("taskIdList")]
        [Validation(Required=false)]
        public List<string> TaskIdList { get; set; }

        [NameInMap("taskPackageId")]
        [Validation(Required=false)]
        public string TaskPackageId { get; set; }

    }

}
