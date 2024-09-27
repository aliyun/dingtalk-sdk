// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetDocContentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("generateCp")]
        [Validation(Required=false)]
        public bool? GenerateCp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("targetFormat")]
        [Validation(Required=false)]
        public string TargetFormat { get; set; }

    }

}
