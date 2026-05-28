// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktre_1_0.Models
{
    public class CreateTicketShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("reporters")]
        [Validation(Required=false)]
        public string ReportersShrink { get; set; }

    }

}
