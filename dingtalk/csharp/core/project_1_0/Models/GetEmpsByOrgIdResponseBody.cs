// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetEmpsByOrgIdResponseBody : TeaModel {
        [NameInMap("empList")]
        [Validation(Required=false)]
        public List<GetEmpsByOrgIdResponseBodyEmpList> EmpList { get; set; }
        public class GetEmpsByOrgIdResponseBodyEmpList : TeaModel {
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("dept_id_list")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            [NameInMap("dingId")]
            [Validation(Required=false)]
            public string DingId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            [NameInMap("unionid")]
            [Validation(Required=false)]
            public string Unionid { get; set; }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
