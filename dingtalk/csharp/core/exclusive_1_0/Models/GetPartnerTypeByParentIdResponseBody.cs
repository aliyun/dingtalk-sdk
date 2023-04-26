// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPartnerTypeByParentIdResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPartnerTypeByParentIdResponseBodyData> Data { get; set; }
        public class GetPartnerTypeByParentIdResponseBodyData : TeaModel {
            [NameInMap("labelId")]
            [Validation(Required=false)]
            public string LabelId { get; set; }

            [NameInMap("typeId")]
            [Validation(Required=false)]
            public float? TypeId { get; set; }

            [NameInMap("typeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
