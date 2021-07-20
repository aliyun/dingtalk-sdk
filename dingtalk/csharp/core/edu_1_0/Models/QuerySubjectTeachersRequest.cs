// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySubjectTeachersRequest : TeaModel {
        /// <summary>
        /// classIds
        /// </summary>
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public List<long?> ClassIds { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        [NameInMap("subjectCode")]
        [Validation(Required=false)]
        public string SubjectCode { get; set; }

    }

}
