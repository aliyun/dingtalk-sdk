// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class DeviceDingRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceKey")]
        [Validation(Required=false)]
        public string DeviceKey { get; set; }

        [NameInMap("paramsJson")]
        [Validation(Required=false)]
        public string ParamsJson { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

    }

}
