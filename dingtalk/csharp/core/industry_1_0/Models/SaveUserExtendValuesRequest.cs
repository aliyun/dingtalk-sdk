// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SaveUserExtendValuesRequest : TeaModel {
        /// <summary>
        /// 字段展示名称
        /// </summary>
        [NameInMap("userDisplayName")]
        [Validation(Required=false)]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// 用户拓展字段key
        /// </summary>
        [NameInMap("userExtendKey")]
        [Validation(Required=false)]
        public string UserExtendKey { get; set; }

        /// <summary>
        /// 用户扩展字段value
        /// </summary>
        [NameInMap("userExtendValue")]
        [Validation(Required=false)]
        public string UserExtendValue { get; set; }

    }

}
