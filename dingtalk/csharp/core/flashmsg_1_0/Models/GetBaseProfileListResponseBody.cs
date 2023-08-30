// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class GetBaseProfileListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetBaseProfileListResponseBodyResult> Result { get; set; }
        public class GetBaseProfileListResponseBodyResult : TeaModel {
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public string AvatarMediaId { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("nickPinyin")]
            [Validation(Required=false)]
            public string NickPinyin { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
