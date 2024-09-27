// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateHrmVersionRollBackStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>show</para>
        /// </summary>
        [NameInMap("configValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231231232</para>
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

    }

}
