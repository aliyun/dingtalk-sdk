// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetCustomerInsightResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCustomerInsightResponseBodyResult Result { get; set; }
        public class GetCustomerInsightResponseBodyResult : TeaModel {
            [NameInMap("intention")]
            [Validation(Required=false)]
            public GetCustomerInsightResponseBodyResultIntention Intention { get; set; }
            public class GetCustomerInsightResponseBodyResultIntention : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("intention")]
                [Validation(Required=false)]
                public string Intention { get; set; }

            }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public GetCustomerInsightResponseBodyResultTag Tag { get; set; }
            public class GetCustomerInsightResponseBodyResultTag : TeaModel {
                [NameInMap("aiTag")]
                [Validation(Required=false)]
                public List<GetCustomerInsightResponseBodyResultTagAiTag> AiTag { get; set; }
                public class GetCustomerInsightResponseBodyResultTagAiTag : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("userTag")]
                [Validation(Required=false)]
                public List<GetCustomerInsightResponseBodyResultTagUserTag> UserTag { get; set; }
                public class GetCustomerInsightResponseBodyResultTagUserTag : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
