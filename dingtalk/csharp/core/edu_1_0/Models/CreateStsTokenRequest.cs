// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateStsTokenRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stsType")]
        [Validation(Required=false)]
        public string StsType { get; set; }

    }

}
