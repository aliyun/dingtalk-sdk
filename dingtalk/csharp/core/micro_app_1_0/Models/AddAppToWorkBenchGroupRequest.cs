// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppToWorkBenchGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namexx</para>
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

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
