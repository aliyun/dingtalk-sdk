// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class TripPlatformUnifiedEntryRequest : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public string Messages { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

    }

}
