// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryGrantInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignQueryGrantInfoResponseBodyResult Result { get; set; }
        public class EsignQueryGrantInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>何一兵</para>
            /// </summary>
            [NameInMap("legalPerson")]
            [Validation(Required=false)]
            public string LegalPerson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18667021101</para>
            /// </summary>
            [NameInMap("mobilePhoneNumber")]
            [Validation(Required=false)]
            public string MobilePhoneNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州天谷信息科技有限公司</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>913301087458306077</para>
            /// </summary>
            [NameInMap("unifiedSocialCredit")]
            [Validation(Required=false)]
            public string UnifiedSocialCredit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>某人名</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
