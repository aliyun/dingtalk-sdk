// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class CreateAsrTranscriptionRequest : TeaModel {
        [NameInMap("bizKey")]
        [Validation(Required=false)]
        public string BizKey { get; set; }

        [NameInMap("phrases")]
        [Validation(Required=false)]
        public List<string> Phrases { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
