// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateInvocableInstanceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("instanceKey")]
        [Validation(Required=false)]
        public string InstanceKey { get; set; }

    }

}
