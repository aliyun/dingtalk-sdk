// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class DeletePermissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public DeletePermissionResponseBodyData Data { get; set; }
        public class DeletePermissionResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("policyList")]
            [Validation(Required=false)]
            public List<DeletePermissionResponseBodyDataPolicyList> PolicyList { get; set; }
            public class DeletePermissionResponseBodyDataPolicyList : TeaModel {
                public List<DeletePermissionResponseBodyDataPolicyListMemberList> MemberList { get; set; }
                public class DeletePermissionResponseBodyDataPolicyListMemberList : TeaModel {
                    public string Id { get; set; }
                    public string Nickname { get; set; }
                    public string Type { get; set; }
                }
                public string Name { get; set; }
                public long? Type { get; set; }
            }
            [NameInMap("privacy")]
            [Validation(Required=false)]
            public string Privacy { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
