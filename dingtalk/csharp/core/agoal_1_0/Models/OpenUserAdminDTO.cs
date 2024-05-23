// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenUserAdminDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

    }

}
