// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("loginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("openId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("visitor")]
        [Validation(Required=false)]
        public bool? Visitor { get; set; }

    }

}
