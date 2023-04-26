// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchSendOTOResponseBody : TeaModel {
        [NameInMap("flowControlledStaffIdList")]
        [Validation(Required=false)]
        public List<string> FlowControlledStaffIdList { get; set; }

        [NameInMap("invalidStaffIdList")]
        [Validation(Required=false)]
        public List<string> InvalidStaffIdList { get; set; }

        [NameInMap("processQueryKey")]
        [Validation(Required=false)]
        public string ProcessQueryKey { get; set; }

    }

}
