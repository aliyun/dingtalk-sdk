// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetCollegeAlumniUserInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCollegeAlumniUserInfoResponseBodyResult Result { get; set; }
        public class GetCollegeAlumniUserInfoResponseBodyResult : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("depts")]
            [Validation(Required=false)]
            public List<GetCollegeAlumniUserInfoResponseBodyResultDepts> Depts { get; set; }
            public class GetCollegeAlumniUserInfoResponseBodyResultDepts : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("hasSubDept")]
                [Validation(Required=false)]
                public bool? HasSubDept { get; set; }

                [NameInMap("isIndustryDept")]
                [Validation(Required=false)]
                public bool? IsIndustryDept { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("intake")]
            [Validation(Required=false)]
            public string Intake { get; set; }

            [NameInMap("inviteId")]
            [Validation(Required=false)]
            public long? InviteId { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outtake")]
            [Validation(Required=false)]
            public string Outtake { get; set; }

            [NameInMap("studentNumber")]
            [Validation(Required=false)]
            public string StudentNumber { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
