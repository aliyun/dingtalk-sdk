// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrgCorrectTaskDetailResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryOrgCorrectTaskDetailResponseBodyResult> Result { get; set; }
        public class QueryOrgCorrectTaskDetailResponseBodyResult : TeaModel {
            [NameInMap("aiMarkId")]
            [Validation(Required=false)]
            public long? AiMarkId { get; set; }

            [NameInMap("aiMarkTime")]
            [Validation(Required=false)]
            public long? AiMarkTime { get; set; }

            [NameInMap("aiModel")]
            [Validation(Required=false)]
            public string AiModel { get; set; }

            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("gradeLevel")]
            [Validation(Required=false)]
            public long? GradeLevel { get; set; }

            [NameInMap("gradeName")]
            [Validation(Required=false)]
            public string GradeName { get; set; }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("scanDeviceId")]
            [Validation(Required=false)]
            public string ScanDeviceId { get; set; }

            [NameInMap("scanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            [NameInMap("schoolName")]
            [Validation(Required=false)]
            public string SchoolName { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            [NameInMap("studentName")]
            [Validation(Required=false)]
            public string StudentName { get; set; }

            [NameInMap("taskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("totalScore")]
            [Validation(Required=false)]
            public double? TotalScore { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
