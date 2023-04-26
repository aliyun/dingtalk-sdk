// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetInterconnectionUrlRequest : TeaModel {
        [NameInMap("appUserAvatar")]
        [Validation(Required=false)]
        public string AppUserAvatar { get; set; }

        [NameInMap("appUserAvatarType")]
        [Validation(Required=false)]
        public int? AppUserAvatarType { get; set; }

        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        [NameInMap("appUserMobileNumber")]
        [Validation(Required=false)]
        public string AppUserMobileNumber { get; set; }

        [NameInMap("appUserName")]
        [Validation(Required=false)]
        public string AppUserName { get; set; }

        [NameInMap("msgPageType")]
        [Validation(Required=false)]
        public int? MsgPageType { get; set; }

        [NameInMap("qrCode")]
        [Validation(Required=false)]
        public string QrCode { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("sourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public int? SourceType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
