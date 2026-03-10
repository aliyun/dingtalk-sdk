// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetInnerAppResponseBody : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("customerAppId")]
        [Validation(Required=false)]
        public string CustomerAppId { get; set; }

        [NameInMap("mobileLoginAddressKey")]
        [Validation(Required=false)]
        public string MobileLoginAddressKey { get; set; }

        [NameInMap("mobileLoginLoginUrl")]
        [Validation(Required=false)]
        public string MobileLoginLoginUrl { get; set; }

        [NameInMap("mobileOriginalHomepageUrl")]
        [Validation(Required=false)]
        public string MobileOriginalHomepageUrl { get; set; }

        [NameInMap("mobileTransferUrl")]
        [Validation(Required=false)]
        public string MobileTransferUrl { get; set; }

        [NameInMap("pcEffectiveHomepageUrl")]
        [Validation(Required=false)]
        public string PcEffectiveHomepageUrl { get; set; }

        [NameInMap("pcLoginAddressKey")]
        [Validation(Required=false)]
        public string PcLoginAddressKey { get; set; }

        [NameInMap("pcLoginLoginUrl")]
        [Validation(Required=false)]
        public string PcLoginLoginUrl { get; set; }

        [NameInMap("pcOriginalHomepageUrl")]
        [Validation(Required=false)]
        public string PcOriginalHomepageUrl { get; set; }

        [NameInMap("pcTransferUrl")]
        [Validation(Required=false)]
        public string PcTransferUrl { get; set; }

    }

}
