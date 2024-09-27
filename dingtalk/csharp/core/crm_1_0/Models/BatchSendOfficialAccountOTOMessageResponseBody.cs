// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchSendOfficialAccountOTOMessageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs1234</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchSendOfficialAccountOTOMessageResponseBodyResult Result { get; set; }
        public class BatchSendOfficialAccountOTOMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("openPushId")]
            [Validation(Required=false)]
            public string OpenPushId { get; set; }

        }

    }

}
