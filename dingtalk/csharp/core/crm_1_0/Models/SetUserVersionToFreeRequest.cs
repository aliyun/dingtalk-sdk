// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SetUserVersionToFreeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>012829186736-1115677667</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>other</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
