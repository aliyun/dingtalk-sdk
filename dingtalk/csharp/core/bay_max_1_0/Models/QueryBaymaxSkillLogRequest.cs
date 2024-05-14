// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbay_max_1_0.Models
{
    public class QueryBaymaxSkillLogRequest : TeaModel {
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("skillExecuteId")]
        [Validation(Required=false)]
        public string SkillExecuteId { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
