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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateAppUuid")]
        [Validation(Required=false)]
        public string TemplateAppUuid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateCorpId")]
        [Validation(Required=false)]
        public string TemplateCorpId { get; set; }

    }

}
