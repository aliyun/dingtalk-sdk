// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StopStreamOutRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stopAllStream")]
        [Validation(Required=false)]
        public bool? StopAllStream { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("streamId")]
        [Validation(Required=false)]
        public string StreamId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
