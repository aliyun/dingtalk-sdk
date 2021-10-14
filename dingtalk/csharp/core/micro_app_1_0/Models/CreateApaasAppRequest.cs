// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class CreateApaasAppRequest : TeaModel {
        [NameInMap("appDesc")]
        [Validation(Required=false)]
        public string AppDesc { get; set; }

        [NameInMap("appIcon")]
        [Validation(Required=false)]
        public string AppIcon { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("bizAppId")]
        [Validation(Required=false)]
        public string BizAppId { get; set; }

        [NameInMap("homepageEditLink")]
        [Validation(Required=false)]
        public string HomepageEditLink { get; set; }

        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        [NameInMap("isShortCut")]
        [Validation(Required=false)]
        public int? IsShortCut { get; set; }

        [NameInMap("ompLink")]
        [Validation(Required=false)]
        public string OmpLink { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        [NameInMap("pcHomepageEditLink")]
        [Validation(Required=false)]
        public string PcHomepageEditLink { get; set; }

        [NameInMap("pcHomepageLink")]
        [Validation(Required=false)]
        public string PcHomepageLink { get; set; }

        [NameInMap("templateKey")]
        [Validation(Required=false)]
        public string TemplateKey { get; set; }

    }

}
