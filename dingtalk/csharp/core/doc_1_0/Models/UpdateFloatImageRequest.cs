// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class UpdateFloatImageRequest : TeaModel {
        [NameInMap("anchor")]
        [Validation(Required=false)]
        public UpdateFloatImageRequestAnchor Anchor { get; set; }
        public class UpdateFloatImageRequestAnchor : TeaModel {
            [NameInMap("col")]
            [Validation(Required=false)]
            public int? Col { get; set; }

            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

        }

        [NameInMap("coordinate")]
        [Validation(Required=false)]
        public UpdateFloatImageRequestCoordinate Coordinate { get; set; }
        public class UpdateFloatImageRequestCoordinate : TeaModel {
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

        [NameInMap("src")]
        [Validation(Required=false)]
        public string Src { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
