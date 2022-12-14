// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetDeveloperMetadataResponseBody : TeaModel {
        /// <summary>
        /// 元数据所关联到的列
        /// </summary>
        [NameInMap("associatedColumn")]
        [Validation(Required=false)]
        public GetDeveloperMetadataResponseBodyAssociatedColumn AssociatedColumn { get; set; }
        public class GetDeveloperMetadataResponseBodyAssociatedColumn : TeaModel {
            /// <summary>
            /// 列号，从0开始
            /// </summary>
            [NameInMap("column")]
            [Validation(Required=false)]
            public int? Column { get; set; }

            [NameInMap("sheetId")]
            [Validation(Required=false)]
            public string SheetId { get; set; }

        }

        /// <summary>
        /// 元数据所关联到的行
        /// </summary>
        [NameInMap("associatedRow")]
        [Validation(Required=false)]
        public GetDeveloperMetadataResponseBodyAssociatedRow AssociatedRow { get; set; }
        public class GetDeveloperMetadataResponseBodyAssociatedRow : TeaModel {
            /// <summary>
            /// 行号，从0开始
            /// </summary>
            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

            /// <summary>
            /// 工作表ID或名称
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
