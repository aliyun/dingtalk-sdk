// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveOpenTerminalInfoRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("logSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        [NameInMap("logType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("openExt")]
        [Validation(Required=false)]
        public string OpenExt { get; set; }

    }

}
