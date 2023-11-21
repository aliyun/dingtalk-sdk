// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class UpgradeTemplateRequest : TeaModel {
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("forceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        [NameInMap("tmcCorpId")]
        [Validation(Required=false)]
        public string TmcCorpId { get; set; }

    }

}
