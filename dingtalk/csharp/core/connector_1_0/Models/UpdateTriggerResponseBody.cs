// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public List<UpdateTriggerResponseBodyItem> Item { get; set; }
        public class UpdateTriggerResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dingTriggerId")]
            [Validation(Required=false)]
            public string DingTriggerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorTriggerId")]
            [Validation(Required=false)]
            public string IntegratorTriggerId { get; set; }

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
            public bool? Success { get; set; }

        }

    }

}
