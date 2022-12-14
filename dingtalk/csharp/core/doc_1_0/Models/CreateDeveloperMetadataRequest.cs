// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateDeveloperMetadataRequest : TeaModel {
        /// <summary>
        /// 元数据所关联到的列
        /// </summary>
        [NameInMap("associatedColumn")]
        [Validation(Required=false)]
        public CreateDeveloperMetadataRequestAssociatedColumn AssociatedColumn { get; set; }
        public class CreateDeveloperMetadataRequestAssociatedColumn : TeaModel {
            /// <summary>
            /// 列号，从0开始
            /// </summary>
            [NameInMap("column")]
            [Validation(Required=false)]
            public int? Column { get; set; }

            [NameInMap("sheet")]
            [Validation(Required=false)]
            public string Sheet { get; set; }

        }

        /// <summary>
        /// 元数据所关联到的行
        /// </summary>
        [NameInMap("associatedRow")]
        [Validation(Required=false)]
        public CreateDeveloperMetadataRequestAssociatedRow AssociatedRow { get; set; }
        public class CreateDeveloperMetadataRequestAssociatedRow : TeaModel {
            /// <summary>
            /// 行号，从0开始
            /// </summary>
            [NameInMap("row")]
            [Validation(Required=false)]
            public int? Row { get; set; }

            /// <summary>
            /// 工作表ID或名称
            /// </summary>
            [NameInMap("sheet")]
            [Validation(Required=false)]
            public string Sheet { get; set; }

        }

        /// <summary>
        /// 元数据值
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
