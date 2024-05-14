// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateActionResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public List<UpdateActionResponseBodyItem> Item { get; set; }
        public class UpdateActionResponseBodyItem : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dingActionId")]
            [Validation(Required=false)]
            public string DingActionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("subErrCode")]
            [Validation(Required=false)]
            public string SubErrCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("subErrMsg")]
            [Validation(Required=false)]
            public string SubErrMsg { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

    }

}
