// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetServiceQualityInspectionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetServiceQualityInspectionResponseBodyResult Result { get; set; }
        public class GetServiceQualityInspectionResponseBodyResult : TeaModel {
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<GetServiceQualityInspectionResponseBodyResultGroupList> GroupList { get; set; }
            public class GetServiceQualityInspectionResponseBodyResultGroupList : TeaModel {
                [NameInMap("itemList")]
                [Validation(Required=false)]
                public List<GetServiceQualityInspectionResponseBodyResultGroupListItemList> ItemList { get; set; }
                public class GetServiceQualityInspectionResponseBodyResultGroupListItemList : TeaModel {
                    [NameInMap("flowName")]
                    [Validation(Required=false)]
                    public string FlowName { get; set; }

                    [NameInMap("isHit")]
                    [Validation(Required=false)]
                    public string IsHit { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public int? Score { get; set; }

                    [NameInMap("script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

    }

}
