// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class GetNodeRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("withPermissionRole")]
        [Validation(Required=false)]
        public bool? WithPermissionRole { get; set; }

        [NameInMap("withStatisticalInfo")]
        [Validation(Required=false)]
        public bool? WithStatisticalInfo { get; set; }

    }

}
