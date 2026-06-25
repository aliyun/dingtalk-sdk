// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class SubmitCreateEnterpriseAgentRequest : TeaModel {
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("previewMediaId")]
        [Validation(Required=false)]
        public string PreviewMediaId { get; set; }

        [NameInMap("robotMediaId")]
        [Validation(Required=false)]
        public string RobotMediaId { get; set; }

        [NameInMap("robotName")]
        [Validation(Required=false)]
        public string RobotName { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
