// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetSuiteAccessTokenRequest : TeaModel {
        /// <summary>
        /// 应用id
        /// </summary>
        [NameInMap("suiteKey")]
        [Validation(Required=false)]
        public string SuiteKey { get; set; }

        /// <summary>
        /// 应用密码
        /// </summary>
        [NameInMap("suiteSecret")]
        [Validation(Required=false)]
        public string SuiteSecret { get; set; }

        /// <summary>
        /// suiteTicket
        /// </summary>
        [NameInMap("suiteTicket")]
        [Validation(Required=false)]
        public string SuiteTicket { get; set; }

    }

}
