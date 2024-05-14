/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class CheckInCrowdsByMobileRequest : TeaModel {
        [NameInMap("crowdIds")]
        [Validation(Required=false)]
        public byte[] CrowdIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

    }

}
