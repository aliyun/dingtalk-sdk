// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchAddPermissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchAddPermissionResponseBodyData Data { get; set; }
        public class BatchAddPermissionResponseBodyData : TeaModel {
            [NameInMap("hasInvalidUser")]
            [Validation(Required=false)]
            public bool? HasInvalidUser { get; set; }

            [NameInMap("permissionTree")]
            [Validation(Required=false)]
            public BatchAddPermissionResponseBodyDataPermissionTree PermissionTree { get; set; }
            public class BatchAddPermissionResponseBodyDataPermissionTree : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("policyList")]
                [Validation(Required=false)]
                public List<BatchAddPermissionResponseBodyDataPermissionTreePolicyList> PolicyList { get; set; }
                public class BatchAddPermissionResponseBodyDataPermissionTreePolicyList : TeaModel {
                    [NameInMap("memberList")]
                    [Validation(Required=false)]
                    public List<BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList> MemberList { get; set; }
                    public class BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList : TeaModel {
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("nickname")]
                        [Validation(Required=false)]
                        public string Nickname { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                [NameInMap("privacy")]
                [Validation(Required=false)]
                public string Privacy { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
