// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetSimpleCubeModelListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSimpleCubeModelListResponseBodyResult> Result { get; set; }
        public class GetSimpleCubeModelListResponseBodyResult : TeaModel {
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<GetSimpleCubeModelListResponseBodyResultChildren> Children { get; set; }
            public class GetSimpleCubeModelListResponseBodyResultChildren : TeaModel {
                [NameInMap("classifiedCode")]
                [Validation(Required=false)]
                public string ClassifiedCode { get; set; }

                [NameInMap("cubeCode")]
                [Validation(Required=false)]
                public string CubeCode { get; set; }

                [NameInMap("dataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("dimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("isDimension")]
                [Validation(Required=false)]
                public string IsDimension { get; set; }

                [NameInMap("isVisible")]
                [Validation(Required=false)]
                public string IsVisible { get; set; }

                [NameInMap("measureType")]
                [Validation(Required=false)]
                public string MeasureType { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("timeFormat")]
                [Validation(Required=false)]
                public string TimeFormat { get; set; }

                [NameInMap("timeGranularityType")]
                [Validation(Required=false)]
                public string TimeGranularityType { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isDimension")]
            [Validation(Required=false)]
            public string IsDimension { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
