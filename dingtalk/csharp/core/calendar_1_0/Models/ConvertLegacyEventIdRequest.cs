// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ConvertLegacyEventIdRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("legacyEventIds")]
        [Validation(Required=false)]
        public List<string> LegacyEventIds { get; set; }

    }

}
