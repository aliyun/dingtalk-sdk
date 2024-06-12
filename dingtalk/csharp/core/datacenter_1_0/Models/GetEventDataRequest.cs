// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetEventDataRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventUid")]
        [Validation(Required=false)]
        public string EventUid { get; set; }

        [NameInMap("subId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

    }

}
