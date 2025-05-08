// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainTalentProfileBasicQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainTalentProfileBasicQueryResponseBodyContent Content { get; set; }
        public class HrbrainTalentProfileBasicQueryResponseBodyContent : TeaModel {
            [NameInMap("profileBaseInfoList")]
            [Validation(Required=false)]
            public List<HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList> ProfileBaseInfoList { get; set; }
            public class HrbrainTalentProfileBasicQueryResponseBodyContentProfileBaseInfoList : TeaModel {
                [NameInMap("age")]
                [Validation(Required=false)]
                public string Age { get; set; }

                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("deptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("jobLevel")]
                [Validation(Required=false)]
                public string JobLevel { get; set; }

                [NameInMap("jobcode")]
                [Validation(Required=false)]
                public string Jobcode { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("seniorityYears")]
                [Validation(Required=false)]
                public string SeniorityYears { get; set; }

                [NameInMap("superName")]
                [Validation(Required=false)]
                public string SuperName { get; set; }

                [NameInMap("superWorkNo")]
                [Validation(Required=false)]
                public string SuperWorkNo { get; set; }

                [NameInMap("workNo")]
                [Validation(Required=false)]
                public string WorkNo { get; set; }

                [NameInMap("workPlace")]
                [Validation(Required=false)]
                public string WorkPlace { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
