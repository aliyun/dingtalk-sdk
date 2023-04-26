// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class DeleteProcessesInstanceRequest : TeaModel {
        [NameInMap("isAutoUpdateBizObject")]
        [Validation(Required=false)]
        public bool? IsAutoUpdateBizObject { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
