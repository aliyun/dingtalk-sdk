// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetSsoUserInfoResponseBody : TeaModel {
        /// <summary>
        /// 用户头像链接
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 微应用免登用户所在企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 微应用免登用户所在企业名称
        /// </summary>
        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// 是否为企业管理员
        /// </summary>
        [NameInMap("isAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
