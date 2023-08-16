// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TemplateCategoriesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public TemplateCategoriesRequestOption Option { get; set; }
        public class TemplateCategoriesRequestOption : TeaModel {
            [NameInMap("categoryStatus")]
            [Validation(Required=false)]
            public int? CategoryStatus { get; set; }

            [NameInMap("industryId")]
            [Validation(Required=false)]
            public int? IndustryId { get; set; }

        }

        [NameInMap("param")]
        [Validation(Required=false)]
        public TemplateCategoriesRequestParam Param { get; set; }
        public class TemplateCategoriesRequestParam : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
