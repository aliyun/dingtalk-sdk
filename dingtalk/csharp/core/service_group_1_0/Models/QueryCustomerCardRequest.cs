// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryCustomerCardRequest : TeaModel {
        /// <summary>
        /// 查询jsonString
        /// </summary>
        [NameInMap("jsonParams")]
        [Validation(Required=false)]
        public string JsonParams { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
