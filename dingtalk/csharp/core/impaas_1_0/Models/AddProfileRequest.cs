// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class AddProfileRequest : TeaModel {
        /// <summary>
        /// 外部app的账号，格式：xxx@channel格式
        /// </summary>
        [NameInMap("appUid")]
        [Validation(Required=false)]
        public string AppUid { get; set; }

        /// <summary>
        /// 头像mediaId，调用Upload接口获得
        /// </summary>
        [NameInMap("avatarMediaId")]
        [Validation(Required=false)]
        public string AvatarMediaId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("mobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

    }

}
