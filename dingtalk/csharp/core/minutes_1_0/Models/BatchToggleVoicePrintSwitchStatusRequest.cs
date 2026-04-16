// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class BatchToggleVoicePrintSwitchStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<BatchToggleVoicePrintSwitchStatusRequestItems> Items { get; set; }
        public class BatchToggleVoicePrintSwitchStatusRequestItems : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("shouldClearVoicePrint")]
            [Validation(Required=false)]
            public bool? ShouldClearVoicePrint { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
