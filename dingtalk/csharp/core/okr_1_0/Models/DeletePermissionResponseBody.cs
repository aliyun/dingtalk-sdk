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

            /// <summary>
            /// 权限列表
            /// </summary>
            [NameInMap("policyList")]
            [Validation(Required=false)]
            public List<DeletePermissionResponseBodyDataPolicyList> PolicyList { get; set; }
            public class DeletePermissionResponseBodyDataPolicyList : TeaModel {
                [NameInMap("memberList")]
                [Validation(Required=false)]
                public List<DeletePermissionResponseBodyDataPolicyListMemberList> MemberList { get; set; }
                public class DeletePermissionResponseBodyDataPolicyListMemberList : TeaModel {
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

            /// <summary>
            /// 是否可见的标识。
            /// </summary>
            [NameInMap("privacy")]
            [Validation(Required=false)]
            public string Privacy { get; set; }

            /// <summary>
            /// 哪种类型的权限。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
