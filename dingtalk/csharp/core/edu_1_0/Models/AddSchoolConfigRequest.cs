// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddSchoolConfigRequest : TeaModel {
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("operatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("temperatureUpLimit")]
        [Validation(Required=false)]
        public long? TemperatureUpLimit { get; set; }

    }

}
