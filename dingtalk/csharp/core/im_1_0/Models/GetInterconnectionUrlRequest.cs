// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetInterconnectionUrlRequest : TeaModel {
        /// <summary>
        /// appUserAvatar
        /// </summary>
        [NameInMap("appUserAvatar")]
        [Validation(Required=false)]
        public string AppUserAvatar { get; set; }

        /// <summary>
        /// appUserAvatarType
        /// </summary>
        [NameInMap("appUserAvatarType")]
        [Validation(Required=false)]
        public int? AppUserAvatarType { get; set; }

        /// <summary>
        /// appUserId
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// appUserMobileNumber
        /// </summary>
        [NameInMap("appUserMobileNumber")]
        [Validation(Required=false)]
        public string AppUserMobileNumber { get; set; }

        /// <summary>
        /// appUserName
        /// </summary>
        [NameInMap("appUserName")]
        [Validation(Required=false)]
        public string AppUserName { get; set; }

        /// <summary>
        /// msgPageType
        /// </summary>
        [NameInMap("msgPageType")]
        [Validation(Required=false)]
        public int? MsgPageType { get; set; }

        /// <summary>
        /// qrCode
        /// </summary>
        [NameInMap("qrCode")]
        [Validation(Required=false)]
        public string QrCode { get; set; }

        /// <summary>
        /// signature
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// sourceCode
        /// </summary>
        [NameInMap("sourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// sourceType
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public int? SourceType { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
