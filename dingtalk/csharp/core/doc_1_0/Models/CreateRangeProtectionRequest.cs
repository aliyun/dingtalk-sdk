// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateRangeProtectionRequest : TeaModel {
        /// <summary>
        /// 对于拥有「可编辑」权限的用户的细化权限配置。
        /// </summary>
        [NameInMap("editableSetting")]
        [Validation(Required=false)]
        public CreateRangeProtectionRequestEditableSetting EditableSetting { get; set; }
        public class CreateRangeProtectionRequestEditableSetting : TeaModel {
            /// <summary>
            /// 是否可删除列
            /// </summary>
            [NameInMap("deleteColumns")]
            [Validation(Required=false)]
            public bool? DeleteColumns { get; set; }

            /// <summary>
            /// 是否可删除行
            /// </summary>
            [NameInMap("deleteRows")]
            [Validation(Required=false)]
            public bool? DeleteRows { get; set; }

            /// <summary>
            /// 是否可修改单元格的值
            /// </summary>
            [NameInMap("editCells")]
            [Validation(Required=false)]
            public bool? EditCells { get; set; }

            /// <summary>
            /// 是否可修改单元格样式
            /// </summary>
            [NameInMap("formatCells")]
            [Validation(Required=false)]
            public bool? FormatCells { get; set; }

            /// <summary>
            /// 是否可插入列
            /// </summary>
            [NameInMap("insertColumns")]
            [Validation(Required=false)]
            public bool? InsertColumns { get; set; }

            /// <summary>
            /// 是否可插入行
            /// </summary>
            [NameInMap("insertRows")]
            [Validation(Required=false)]
            public bool? InsertRows { get; set; }

            /// <summary>
            /// 是否可显示、隐藏列
            /// </summary>
            [NameInMap("toggleColumnsVisibility")]
            [Validation(Required=false)]
            public bool? ToggleColumnsVisibility { get; set; }

            /// <summary>
            /// 是否可显示、隐藏行
            /// </summary>
            [NameInMap("toggleRowsVisibility")]
            [Validation(Required=false)]
            public bool? ToggleRowsVisibility { get; set; }

        }

        /// <summary>
        /// 其它用户的权限
        /// </summary>
        [NameInMap("otherUserPermission")]
        [Validation(Required=false)]
        public string OtherUserPermission { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
