// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class DecodePayCodeResponseBody : TeaModel {
        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户是否还在组织内
        /// </summary>
        [NameInMap("userInCorp")]
        [Validation(Required=false)]
        public bool? UserInCorp { get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// 支付宝付款码
        /// </summary>
        [NameInMap("alipayCode")]
        [Validation(Required=false)]
        public string AlipayCode { get; set; }

        /// <summary>
        /// 用户和企业关系
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

    }

}
