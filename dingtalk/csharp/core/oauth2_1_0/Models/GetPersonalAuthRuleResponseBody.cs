// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetPersonalAuthRuleResponseBody : TeaModel {
        /// <summary>
        /// list
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetPersonalAuthRuleResponseBodyResult> Result { get; set; }
        public class GetPersonalAuthRuleResponseBodyResult : TeaModel {
            /// <summary>
            /// authItems
            /// </summary>
            [NameInMap("authItems")]
            [Validation(Required=false)]
            public List<string> AuthItems { get; set; }

            /// <summary>
            /// resource
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

    }

}
