// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetBranchAuthDataRequest : TeaModel {
        /// <summary>
        /// 分支组织corpId
        /// </summary>
        [NameInMap("branchCorpId")]
        [Validation(Required=false)]
        public string BranchCorpId { get; set; }

        /// <summary>
        /// 数据编码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, string> Body { get; set; }

    }

}
