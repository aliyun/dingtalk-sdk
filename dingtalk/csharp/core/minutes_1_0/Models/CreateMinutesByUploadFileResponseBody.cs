// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class CreateMinutesByUploadFileResponseBody : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7632756964313430aaaaaaaaaaaaaaaaaaaaaaaaaa7363731333633305f35</para>
        /// </summary>
        [NameInMap("taskUuid")]
        [Validation(Required=false)]
        public string TaskUuid { get; set; }

    }

}
