// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class CheckDeviceUpdateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<CheckDeviceUpdateRequestBody> Body { get; set; }
        public class CheckDeviceUpdateRequestBody : TeaModel {
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

    }

}
