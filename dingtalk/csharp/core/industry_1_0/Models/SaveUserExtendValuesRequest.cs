// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SaveUserExtendValuesRequest : TeaModel {
        [NameInMap("userDisplayName")]
        [Validation(Required=false)]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userExtendKey")]
        [Validation(Required=false)]
        public string UserExtendKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userExtendValue")]
        [Validation(Required=false)]
        public string UserExtendValue { get; set; }

    }

}
