// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryPayAccountListRequest : TeaModel {
        /// <summary>
        /// 组织corpId
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// Isv coprId
        /// </summary>
        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        /// <summary>
        /// 应用suiteId
        /// </summary>
        [NameInMap("suiteId")]
        [Validation(Required=false)]
        public string SuiteId { get; set; }

    }

}
