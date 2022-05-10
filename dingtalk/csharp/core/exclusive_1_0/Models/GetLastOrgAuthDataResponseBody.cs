// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetLastOrgAuthDataResponseBody : TeaModel {
        /// <summary>
        /// 未通过原因
        /// </summary>
        [NameInMap("authRemark")]
        [Validation(Required=false)]
        public string AuthRemark { get; set; }

        /// <summary>
        /// 审核状态 0 未提交， 1未审核 2 失败 3通过
        /// </summary>
        [NameInMap("authStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

    }

}
