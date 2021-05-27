// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// 昵称
        /// </summary>
        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        [NameInMap("openId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        /// <summary>
        /// unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 个人邮箱
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// 手机号对应的国家号
        /// </summary>
        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

    }

}
