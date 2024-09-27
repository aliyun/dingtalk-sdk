// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SaveFormInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>99999</para>
        /// </summary>
        [NameInMap("openContactId")]
        [Validation(Required=false)]
        public string OpenContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88888</para>
        /// </summary>
        [NameInMap("openCustomerId")]
        [Validation(Required=false)]
        public string OpenCustomerId { get; set; }

    }

}
