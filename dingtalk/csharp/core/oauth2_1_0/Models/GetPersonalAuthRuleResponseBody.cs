// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetPersonalAuthRuleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetPersonalAuthRuleResponseBodyResult> Result { get; set; }
        public class GetPersonalAuthRuleResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("authItems")]
            [Validation(Required=false)]
            public List<string> AuthItems { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

    }

}
