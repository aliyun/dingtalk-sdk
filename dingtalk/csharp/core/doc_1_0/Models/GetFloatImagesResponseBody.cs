// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetFloatImagesResponseBody : TeaModel {
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<GetFloatImagesResponseBodyValue> Value { get; set; }
        public class GetFloatImagesResponseBodyValue : TeaModel {
            [NameInMap("anchor")]
            [Validation(Required=false)]
            public GetFloatImagesResponseBodyValueAnchor Anchor { get; set; }
            public class GetFloatImagesResponseBodyValueAnchor : TeaModel {
                [NameInMap("col")]
                [Validation(Required=false)]
                public int? Col { get; set; }

                [NameInMap("row")]
                [Validation(Required=false)]
                public int? Row { get; set; }

            }

            [NameInMap("coordinate")]
            [Validation(Required=false)]
            public GetFloatImagesResponseBodyValueCoordinate Coordinate { get; set; }
            public class GetFloatImagesResponseBodyValueCoordinate : TeaModel {
                [NameInMap("height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                [NameInMap("offsetX")]
                [Validation(Required=false)]
                public double? OffsetX { get; set; }

                [NameInMap("offsetY")]
                [Validation(Required=false)]
                public double? OffsetY { get; set; }

                [NameInMap("width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("src")]
            [Validation(Required=false)]
            public string Src { get; set; }

        }

    }

}
