// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleShrinkRequest : TeaModel {
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public string ClassIdsShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

    }

}
