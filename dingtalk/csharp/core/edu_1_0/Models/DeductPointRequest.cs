// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeductPointRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("deductDesc")]
        [Validation(Required=false)]
        public string DeductDesc { get; set; }

        [NameInMap("deductDetailUrl")]
        [Validation(Required=false)]
        public string DeductDetailUrl { get; set; }

        [NameInMap("deductNum")]
        [Validation(Required=false)]
        public int? DeductNum { get; set; }

        [NameInMap("pointType")]
        [Validation(Required=false)]
        public string PointType { get; set; }

    }

}
