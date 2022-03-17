// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdatePrivacyResponseBody : TeaModel {
        /// <summary>
        /// 返回的数据。
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdatePrivacyResponseBodyData Data { get; set; }
        public class UpdatePrivacyResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("policyList")]
            [Validation(Required=false)]
            public List<UpdatePrivacyResponseBodyDataPolicyList> PolicyList { get; set; }
            public class UpdatePrivacyResponseBodyDataPolicyList : TeaModel {
                public List<UpdatePrivacyResponseBodyDataPolicyListMemberList> MemberList { get; set; }
                public class UpdatePrivacyResponseBodyDataPolicyListMemberList : TeaModel {
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
