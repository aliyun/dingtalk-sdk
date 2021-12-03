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
        /// dingCorpId
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// dingUserId
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// msgPageSettingId
        /// </summary>
        [NameInMap("msgPageSettingId")]
        [Validation(Required=false)]
        public long? MsgPageSettingId { get; set; }

    }

}
