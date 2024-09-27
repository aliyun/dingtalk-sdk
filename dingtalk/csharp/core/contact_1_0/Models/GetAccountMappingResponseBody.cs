// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetAccountMappingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAccountMappingResponseBodyResult Result { get; set; }
        public class GetAccountMappingResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BizName1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>o_123</para>
            /// </summary>
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t_123,如果不区分，填写固定值</para>
            /// </summary>
            [NameInMap("outTenantId")]
            [Validation(Required=false)]
            public string OutTenantId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id_123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
