// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SetRobotConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SetRobotConfigResponseBodyResult Result { get; set; }
        public class SetRobotConfigResponseBodyResult : TeaModel {
            [NameInMap("configKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }
            [NameInMap("configValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }
        };

    }

}
