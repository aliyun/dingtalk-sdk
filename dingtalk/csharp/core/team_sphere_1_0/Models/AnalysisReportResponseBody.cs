// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class AnalysisReportResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AnalysisReportResponseBodyResult> Result { get; set; }
        public class AnalysisReportResponseBodyResult : TeaModel {
            [NameInMap("cols")]
            [Validation(Required=false)]
            public List<AnalysisReportResponseBodyResultCols> Cols { get; set; }
            public class AnalysisReportResponseBodyResultCols : TeaModel {
                [NameInMap("baseType")]
                [Validation(Required=false)]
                public string BaseType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            [NameInMap("listQuery")]
            [Validation(Required=false)]
            public List<List<AnalysisReportResponseBodyResultListQuery>> ListQuery { get; set; }
            public class AnalysisReportResponseBodyResultListQuery : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("rows")]
            [Validation(Required=false)]
            public List<List<string>> Rows { get; set; }

            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("visualizationSettings")]
            [Validation(Required=false)]
            public AnalysisReportResponseBodyResultVisualizationSettings VisualizationSettings { get; set; }
            public class AnalysisReportResponseBodyResultVisualizationSettings : TeaModel {
                [NameInMap("dimension")]
                [Validation(Required=false)]
                public long? Dimension { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
