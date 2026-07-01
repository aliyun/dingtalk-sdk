// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class ATMDeviceWorkNotifyRequest : TeaModel {
        [NameInMap("creatorCorpId")]
        [Validation(Required=false)]
        public string CreatorCorpId { get; set; }

        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("notifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        [NameInMap("paramContent")]
        [Validation(Required=false)]
        public string ParamContent { get; set; }

        [NameInMap("targetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

    }

}
