// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class VoiceCloneRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("voiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
