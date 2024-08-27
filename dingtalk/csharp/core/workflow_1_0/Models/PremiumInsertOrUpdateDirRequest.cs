// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumInsertOrUpdateDirRequest : TeaModel {
        [NameInMap("bizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name18n")]
        [Validation(Required=false)]
        public string Name18n { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

    }

}
