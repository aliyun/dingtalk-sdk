// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateStudentDeptInfoRequest : TeaModel {
        /// <summary>
        /// 部门id
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [NameInMap("studentNumber")]
        [Validation(Required=false)]
        public string StudentNumber { get; set; }

    }

}
