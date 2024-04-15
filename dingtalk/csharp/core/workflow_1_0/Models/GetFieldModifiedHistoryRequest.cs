// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetFieldModifiedHistoryRequest : TeaModel {
        [NameInMap("fieldId")]
        [Validation(Required=false)]
        public string FieldId { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
