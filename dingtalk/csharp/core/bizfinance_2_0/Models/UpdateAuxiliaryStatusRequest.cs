// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateAuxiliaryStatusRequest : TeaModel {
        [NameInMap("auxiliaryId")]
        [Validation(Required=false)]
        public string AuxiliaryId { get; set; }

        [NameInMap("auxiliaryType")]
        [Validation(Required=false)]
        public string AuxiliaryType { get; set; }

        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
