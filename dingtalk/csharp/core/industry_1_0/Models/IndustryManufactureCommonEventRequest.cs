// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureCommonEventRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("bizData")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizData { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public List<string> EventType { get; set; }

    }

}
