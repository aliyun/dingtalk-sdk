// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetSecurityConfigMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSecurityConfigMemberResponseBodyResult Result { get; set; }
        public class GetSecurityConfigMemberResponseBodyResult : TeaModel {
            [NameInMap("hasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public float? NextToken { get; set; }

            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

            [NameInMap("userInfos")]
            [Validation(Required=false)]
            public List<GetSecurityConfigMemberResponseBodyResultUserInfos> UserInfos { get; set; }
            public class GetSecurityConfigMemberResponseBodyResultUserInfos : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
