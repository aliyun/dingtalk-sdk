// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactInfoResponseBody : TeaModel {
        /// <summary>
        /// 已授权的字段
        /// </summary>
        [NameInMap("authItems")]
        [Validation(Required=false)]
        public List<string> AuthItems { get; set; }

        /// <summary>
        /// 联系人主企业名称
        /// </summary>
        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 手机号国家码
        /// </summary>
        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// 联系人的unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 已授权的字段
        /// </summary>
        [NameInMap("userInfos")]
        [Validation(Required=false)]
        public List<string> UserInfos { get; set; }

    }

}
