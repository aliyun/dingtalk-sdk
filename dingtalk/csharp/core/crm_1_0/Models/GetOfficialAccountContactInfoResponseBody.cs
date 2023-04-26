// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactInfoResponseBody : TeaModel {
        [NameInMap("authItems")]
        [Validation(Required=false)]
        public List<string> AuthItems { get; set; }

        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userInfos")]
        [Validation(Required=false)]
        public List<string> UserInfos { get; set; }

    }

}
