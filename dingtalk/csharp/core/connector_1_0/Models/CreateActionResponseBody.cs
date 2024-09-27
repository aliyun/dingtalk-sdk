// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateActionResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public List<CreateActionResponseBodyItem> Item { get; set; }
        public class CreateActionResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dingActionId")]
            [Validation(Required=false)]
            public string DingActionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("subErrCode")]
            [Validation(Required=false)]
            public string SubErrCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("subErrMsg")]
            [Validation(Required=false)]
            public string SubErrMsg { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

    }

}
