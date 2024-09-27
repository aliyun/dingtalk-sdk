// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public List<UpdateConnectorResponseBodyItem> Item { get; set; }
        public class UpdateConnectorResponseBodyItem : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>G-CONN-101921B15FE0212B4AF70</para>
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            [NameInMap("subErrCode")]
            [Validation(Required=false)]
            public string SubErrCode { get; set; }

            [NameInMap("subErrMsg")]
            [Validation(Required=false)]
            public string SubErrMsg { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
