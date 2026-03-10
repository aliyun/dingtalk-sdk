// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class QueryBusinessCodeInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("businessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
