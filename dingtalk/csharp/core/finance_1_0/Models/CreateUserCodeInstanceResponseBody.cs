// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateUserCodeInstanceResponseBody : TeaModel {
        /// <summary>
        /// 码详情跳转地址
        /// </summary>
        [NameInMap("codeDetailUrl")]
        [Validation(Required=false)]
        public string CodeDetailUrl { get; set; }

        /// <summary>
        /// 码ID
        /// </summary>
        [NameInMap("codeId")]
        [Validation(Required=false)]
        public string CodeId { get; set; }

    }

}
