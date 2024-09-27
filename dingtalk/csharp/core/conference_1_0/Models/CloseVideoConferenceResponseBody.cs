// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CloseVideoConferenceResponseBody : TeaModel {
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

    }

}
