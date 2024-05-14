// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdatePrivacyResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdatePrivacyResponseBodyData Data { get; set; }
        public class UpdatePrivacyResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("policyList")]
            [Validation(Required=false)]
            public List<UpdatePrivacyResponseBodyDataPolicyList> PolicyList { get; set; }
            public class UpdatePrivacyResponseBodyDataPolicyList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("memberList")]
                [Validation(Required=false)]
                public List<UpdatePrivacyResponseBodyDataPolicyListMemberList> MemberList { get; set; }
                public class UpdatePrivacyResponseBodyDataPolicyListMemberList : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("nickname")]
                    [Validation(Required=false)]
                    public string Nickname { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("privacy")]
            [Validation(Required=false)]
            public string Privacy { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
