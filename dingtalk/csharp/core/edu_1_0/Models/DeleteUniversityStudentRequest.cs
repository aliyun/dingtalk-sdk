// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeleteUniversityStudentRequest : TeaModel {
        /// <summary>
        /// 班级ID
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        /// <summary>
        /// 操作人用户ID
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 学生用户ID
        /// </summary>
        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

    }

}
