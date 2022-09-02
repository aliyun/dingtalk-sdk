// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class IsFriendRequest : TeaModel {
        /// <summary>
        /// 手机号码
        /// </summary>
        [NameInMap("mobileNo")]
        [Validation(Required=false)]
        public string MobileNo { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
