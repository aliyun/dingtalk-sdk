// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetSchemaResponseBody : TeaModel {
        /// <summary>
        /// 当前版本。
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// schema内容。
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
