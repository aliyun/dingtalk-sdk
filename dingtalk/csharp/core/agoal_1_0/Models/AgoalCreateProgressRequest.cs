// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalCreateProgressRequest : TeaModel {
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        [NameInMap("mergeIntoLatestProgress")]
        [Validation(Required=false)]
        public bool? MergeIntoLatestProgress { get; set; }

        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("plainText")]
        [Validation(Required=false)]
        public string PlainText { get; set; }

        [NameInMap("progressMergePeriod")]
        [Validation(Required=false)]
        public string ProgressMergePeriod { get; set; }

    }

}
