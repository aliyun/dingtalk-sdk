// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ExclusiveCreateDingPortalRequest : TeaModel {
        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("templateAppUuid")]
        [Validation(Required=false)]
        public string TemplateAppUuid { get; set; }

        [NameInMap("templateCorpId")]
        [Validation(Required=false)]
        public string TemplateCorpId { get; set; }

    }

}
