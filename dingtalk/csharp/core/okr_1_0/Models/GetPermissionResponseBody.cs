// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetPermissionResponseBody : TeaModel {
        /// <summary>
        /// 返回的数据。
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPermissionResponseBodyData Data { get; set; }
        public class GetPermissionResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 权限列表
            /// </summary>
            [NameInMap("policyList")]
            [Validation(Required=false)]
            public List<GetPermissionResponseBodyDataPolicyList> PolicyList { get; set; }
            public class GetPermissionResponseBodyDataPolicyList : TeaModel {
                [NameInMap("memberList")]
                [Validation(Required=false)]
                public List<GetPermissionResponseBodyDataPolicyListMemberList> MemberList { get; set; }
                public class GetPermissionResponseBodyDataPolicyListMemberList : TeaModel {
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
