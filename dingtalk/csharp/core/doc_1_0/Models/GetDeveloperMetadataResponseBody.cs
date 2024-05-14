// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetDeveloperMetadataResponseBody : TeaModel {
        [NameInMap("associatedColumn")]
        [Validation(Required=false)]
        public GetDeveloperMetadataResponseBodyAssociatedColumn AssociatedColumn { get; set; }
        public class GetDeveloperMetadataResponseBodyAssociatedColumn : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("column")]
            [Validation(Required=false)]
            public int? Column { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sheetId")]
            [Validation(Required=false)]
            public string SheetId { get; set; }

        }

        [NameInMap("associatedRow")]
        [Validation(Required=false)]
        public GetDeveloperMetadataResponseBodyAssociatedRow AssociatedRow { get; set; }
        public class GetDeveloperMetadataResponseBodyAssociatedRow : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sheetId")]
            [Validation(Required=false)]
            public string SheetId { get; set; }

        }

        [NameInMap("value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
