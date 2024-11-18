// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetEmpsByOrgIdHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("dingAccessTokenType")]
        [Validation(Required=false)]
        public string DingAccessTokenType { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public string DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public string DingOrgId { get; set; }

        [NameInMap("x-acs-dingtalk-access-token")]
        [Validation(Required=false)]
        public string XAcsDingtalkAccessToken { get; set; }

    }

}
