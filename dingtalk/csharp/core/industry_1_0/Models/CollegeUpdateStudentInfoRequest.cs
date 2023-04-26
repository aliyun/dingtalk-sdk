// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateStudentInfoRequest : TeaModel {
        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, string> EmpExtension { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        [NameInMap("studentName")]
        [Validation(Required=false)]
        public string StudentName { get; set; }

    }

}
