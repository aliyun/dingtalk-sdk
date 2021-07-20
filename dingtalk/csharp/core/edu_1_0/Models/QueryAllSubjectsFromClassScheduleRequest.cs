// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleRequest : TeaModel {
        /// <summary>
        /// classIds
        /// </summary>
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public List<long?> ClassIds { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

    }

}
