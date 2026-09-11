// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QuerySalesInsightsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QuerySalesInsightsResponseBodyResult> Result { get; set; }
        public class QuerySalesInsightsResponseBodyResult : TeaModel {
            [NameInMap("analysisDate")]
            [Validation(Required=false)]
            public string AnalysisDate { get; set; }

            [NameInMap("capabilityRadar")]
            [Validation(Required=false)]
            public QuerySalesInsightsResponseBodyResultCapabilityRadar CapabilityRadar { get; set; }
            public class QuerySalesInsightsResponseBodyResultCapabilityRadar : TeaModel {
                [NameInMap("dimensions")]
                [Validation(Required=false)]
                public List<QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions> Dimensions { get; set; }
                public class QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }

            [NameInMap("insightList")]
            [Validation(Required=false)]
            public List<QuerySalesInsightsResponseBodyResultInsightList> InsightList { get; set; }
            public class QuerySalesInsightsResponseBodyResultInsightList : TeaModel {
                [NameInMap("commonSummary")]
                [Validation(Required=false)]
                public List<QuerySalesInsightsResponseBodyResultInsightListCommonSummary> CommonSummary { get; set; }
                public class QuerySalesInsightsResponseBodyResultInsightListCommonSummary : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("priorityText")]
                    [Validation(Required=false)]
                    public string PriorityText { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("teamCode")]
            [Validation(Required=false)]
            public string TeamCode { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
