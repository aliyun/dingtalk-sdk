// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateDeveloperMetadataRequest : TeaModel {
        [NameInMap("associatedColumn")]
        [Validation(Required=false)]
        public CreateDeveloperMetadataRequestAssociatedColumn AssociatedColumn { get; set; }
        public class CreateDeveloperMetadataRequestAssociatedColumn : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("column")]
            [Validation(Required=false)]
            public int? Column { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sheet")]
            [Validation(Required=false)]
            public string Sheet { get; set; }

        }

        [NameInMap("associatedRow")]
        [Validation(Required=false)]
        public CreateDeveloperMetadataRequestAssociatedRow AssociatedRow { get; set; }
        public class CreateDeveloperMetadataRequestAssociatedRow : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sheet")]
            [Validation(Required=false)]
            public string Sheet { get; set; }

        }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
