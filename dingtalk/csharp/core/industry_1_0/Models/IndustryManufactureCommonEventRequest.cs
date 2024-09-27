// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureCommonEventRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("bizData")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public List<string> EventType { get; set; }

    }

}
