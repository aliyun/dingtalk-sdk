// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetInnerAppRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>corpxxxx</para>
        /// </summary>
        [NameInMap("ecologicalCorpId")]
        [Validation(Required=false)]
        public string EcologicalCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

    }

}
