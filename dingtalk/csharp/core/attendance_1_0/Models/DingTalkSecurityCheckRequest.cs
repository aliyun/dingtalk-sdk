// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class DingTalkSecurityCheckRequest : TeaModel {
        /// <summary>
        /// 客户端版本号
        /// </summary>
        [NameInMap("clientVer")]
        [Validation(Required=false)]
        public string ClientVer { get; set; }

        /// <summary>
        /// 客户端平台类型(iOS,Android)
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// 客户端平台平台版本
        /// </summary>
        [NameInMap("platformVer")]
        [Validation(Required=false)]
        public string PlatformVer { get; set; }

        /// <summary>
        /// 加密字符
        /// </summary>
        [NameInMap("sec")]
        [Validation(Required=false)]
        public string Sec { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
