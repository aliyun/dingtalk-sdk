// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ExclusiveCreateDingPortalRequest : TeaModel {
        /// <summary>
        /// 工作台名称。
        /// </summary>
        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        /// <summary>
        /// 被操纵企业ID。
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// 模版id。
        /// </summary>
        [NameInMap("templateAppUuid")]
        [Validation(Required=false)]
        public string TemplateAppUuid { get; set; }

        /// <summary>
        /// 模版所属的组织id。
        /// </summary>
        [NameInMap("templateCorpId")]
        [Validation(Required=false)]
        public string TemplateCorpId { get; set; }

    }

}
