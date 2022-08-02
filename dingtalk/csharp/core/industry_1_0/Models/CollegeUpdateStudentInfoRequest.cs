// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateStudentInfoRequest : TeaModel {
        /// <summary>
        /// 人员拓展信息
        /// </summary>
        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, string> EmpExtension { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 入学年份
        /// </summary>
        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// studentId
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [NameInMap("studentName")]
        [Validation(Required=false)]
        public string StudentName { get; set; }

    }

}
