// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySubjectTeachersRequest : TeaModel {
        /// <summary>
        /// 班级ids
        /// </summary>
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public List<long?> ClassIds { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 学科code
        /// </summary>
        [NameInMap("subjectCode")]
        [Validation(Required=false)]
        public string SubjectCode { get; set; }

    }

}
