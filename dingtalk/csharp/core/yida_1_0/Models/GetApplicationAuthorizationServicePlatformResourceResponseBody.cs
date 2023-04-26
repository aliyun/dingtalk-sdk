// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetApplicationAuthorizationServicePlatformResourceResponseBody : TeaModel {
        [NameInMap("accountTotalAmount")]
        [Validation(Required=false)]
        public int? AccountTotalAmount { get; set; }

        [NameInMap("accountUsageAmount")]
        [Validation(Required=false)]
        public int? AccountUsageAmount { get; set; }

        [NameInMap("appTotalAmount")]
        [Validation(Required=false)]
        public int? AppTotalAmount { get; set; }

        [NameInMap("attachmentTotalAmount")]
        [Validation(Required=false)]
        public long? AttachmentTotalAmount { get; set; }

        [NameInMap("attachmentUsageAmount")]
        [Validation(Required=false)]
        public long? AttachmentUsageAmount { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("instanceTotalAmount")]
        [Validation(Required=false)]
        public long? InstanceTotalAmount { get; set; }

        [NameInMap("instanceUsageAmount")]
        [Validation(Required=false)]
        public long? InstanceUsageAmount { get; set; }

        [NameInMap("pluginUsageAmount")]
        [Validation(Required=false)]
        public long? PluginUsageAmount { get; set; }

    }

}
