// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetEmpsByOrgIdResponseBody : TeaModel {
        /// <summary>
        /// empList
        /// </summary>
        [NameInMap("empList")]
        [Validation(Required=false)]
        public List<GetEmpsByOrgIdResponseBodyEmpList> EmpList { get; set; }
        public class GetEmpsByOrgIdResponseBodyEmpList : TeaModel {
            /// <summary>
            /// dingId
            /// </summary>
            [NameInMap("dingId")]
            [Validation(Required=false)]
            public string DingId { get; set; }

            /// <summary>
            /// unionId
            /// </summary>
            [NameInMap("unionid")]
            [Validation(Required=false)]
            public string Unionid { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// nick
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// userid
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

            /// <summary>
            /// orgId
            /// </summary>
            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            /// <summary>
            /// avatar
            /// </summary>
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// deptIdList
            /// </summary>
            [NameInMap("dept_id_list")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

        /// <summary>
        /// hasMore
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
