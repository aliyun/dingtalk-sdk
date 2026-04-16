// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateFloatImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("anchor")]
        [Validation(Required=false)]
        public CreateFloatImageRequestAnchor Anchor { get; set; }
        public class CreateFloatImageRequestAnchor : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("col")]
            [Validation(Required=false)]
            public int? Col { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("coordinate")]
        [Validation(Required=false)]
        public CreateFloatImageRequestCoordinate Coordinate { get; set; }
        public class CreateFloatImageRequestCoordinate : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("offsetX")]
            [Validation(Required=false)]
            public double? OffsetX { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("offsetY")]
            [Validation(Required=false)]
            public double? OffsetY { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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
