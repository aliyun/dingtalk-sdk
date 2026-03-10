// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListOrgPluginsHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("dingAccessTokenType")]
        [Validation(Required=false)]
        public string DingAccessTokenType { get; set; }

        [NameInMap("dingClientId")]
        [Validation(Required=false)]
        public string DingClientId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public string DingIsvOrgId { get; set; }

        [NameInMap("dingOpenAppOrgId")]
        [Validation(Required=false)]
        public string DingOpenAppOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public string DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("x-acs-dingtalk-access-token")]
        [Validation(Required=false)]
        public string XAcsDingtalkAccessToken { get; set; }

    }

}
