// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabMetaResponseBody : TeaModel {
        [NameInMap("baseViewTabModels")]
        [Validation(Required=false)]
        public List<GetRelatedViewTabMetaResponseBodyBaseViewTabModels> BaseViewTabModels { get; set; }
        public class GetRelatedViewTabMetaResponseBodyBaseViewTabModels : TeaModel {
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            [NameInMap("relateComponentId")]
            [Validation(Required=false)]
            public string RelateComponentId { get; set; }

            [NameInMap("tabTitle")]
            [Validation(Required=false)]
            public string TabTitle { get; set; }

        }

    }

}
