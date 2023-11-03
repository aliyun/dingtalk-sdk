// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class ConsumePointRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public ConsumePointRequestBody Body { get; set; }
        public class ConsumePointRequestBody : TeaModel {
            [NameInMap("consumeDetail")]
            [Validation(Required=false)]
            public ConsumePointRequestBodyConsumeDetail ConsumeDetail { get; set; }
            public class ConsumePointRequestBodyConsumeDetail : TeaModel {
                [NameInMap("benefit")]
                [Validation(Required=false)]
                public ConsumePointRequestBodyConsumeDetailBenefit Benefit { get; set; }
                public class ConsumePointRequestBodyConsumeDetailBenefit : TeaModel {
                    [NameInMap("benefitId")]
                    [Validation(Required=false)]
                    public string BenefitId { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("supplierName")]
                    [Validation(Required=false)]
                    public string SupplierName { get; set; }

                    [NameInMap("useUrl")]
                    [Validation(Required=false)]
                    public string UseUrl { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("pointPoolCode")]
            [Validation(Required=false)]
            public string PointPoolCode { get; set; }

            [NameInMap("points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

    }

}
