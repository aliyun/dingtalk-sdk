// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class UpdateApaasAppRequest : TeaModel {
        [NameInMap("appIcon")]
        [Validation(Required=false)]
        public string AppIcon { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("appStatus")]
        [Validation(Required=false)]
        public int? AppStatus { get; set; }

        [NameInMap("bizAppId")]
        [Validation(Required=false)]
        public string BizAppId { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
