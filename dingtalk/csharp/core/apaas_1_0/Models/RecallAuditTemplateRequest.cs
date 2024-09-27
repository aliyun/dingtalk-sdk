// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class RecallAuditTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateKeys")]
        [Validation(Required=false)]
        public List<string> TemplateKeys { get; set; }

    }

}
